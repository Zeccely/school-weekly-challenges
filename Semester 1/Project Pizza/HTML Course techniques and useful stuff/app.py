from flask import Flask, render_template, redirect, url_for, request, session, jsonify, make_response
import serial
import sqlite3


app = Flask(__name__)
app.secret_key = 'your_secret_key'


ser = serial.Serial('COM3')
connection = sqlite3.connect('menu.db')
db = connection.cursor()

# Read the SQL file
with open('menu.sql', 'r') as sql_file:
    sql_script = sql_file.read()

# Execute the SQL commands
try:
    db.executescript(sql_script)
    connection.commit()
    print("Database initialized successfully.")
except sqlite3.Error as e:
    print(f"An error occurred: {e}")
finally:
    connection.close()


@app.route('/')
def index():
    return render_template('index.html')

@app.route('/menu', methods=["GET", "POST"])
def menu():
    if request.method == "POST":
        try:
            item_id = request.form.get("item_id", None)

            item = db.execute("SELECT item_id FROM cart WHERE item_id = ?", (item_id))
            item = item.fetchall()

            if item:
                return "ITEM IS ALREADY ADDED" 
            else:
                items = db. execute("INSERT INTO cart (item_id) VALUES(?)", item_id)
                items = connection.commit()

        except Exception: 
            return "ERROR"
    else:
        items = db.execute("SELECT * FROM items")
        items = items.fetchall()

    return render_template('menu.html', items=items)

@app.route('/cart')
def cart():
    
    cart = db.execute("SELECT * FROM cart INNER JOIN items ON cart.item_id = items.item_id")
    cart = cart.fetchall()

    return render_template('cart.html', cart=cart)

@app.route('/timeleft')
def timeleft():
    if ser.in_waiting > 0:  # Check if data is available
        try:
            # ead the countdown value from serial port
            line = ser.readline().decode('utf-8').rstrip()
            countdown = int(line)  # Convert received data to integer
            
            # pdate template with the received countdown value
            # return render_template('index.html', countdown=countdown)
        except ValueError:
            pass  # Handle potential errors inreceived data
    
    return render_template('timeleft.html', countdown=None)


if __name__ == '__main__':
    
    app.run(debug=False) 