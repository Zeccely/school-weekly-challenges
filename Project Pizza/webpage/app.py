from flask import Flask, render_template, redirect, url_for, request, session, jsonify, make_response
import serial
import sqlite3
import json
import uuid


app = Flask(__name__)
app.secret_key = 'your_secret_key'



# ser = serial.Serial('COM3')
connection = sqlite3.connect('menu.db', check_same_thread=False)
db = connection.cursor()

@app.before_request
def ensure_session():
    if 'session_id' not in session:
        session['session_id'] = str(uuid.uuid4())

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
    connection = sqlite3.connect('menu.db', check_same_thread=False)
    connection.row_factory = sqlite3.Row
    db = connection.cursor()
    items = db.execute("SELECT item_id, name, price FROM items").fetchall()


    # If an item is being added to the cart
    if request.method == "POST":
        item_id = request.form.get("item_id", None)
        
        if item_id:
            try:
                # Add item to cart for the current session
                db.execute("INSERT INTO cart (session_id, item_id) VALUES (?, ?)", (session['session_id'], item_id))
                connection.commit()
            except sqlite3.Error as e:
                print(f"An error occurred: {e}")
                return "ERROR", 500
        else:
            print("No item_id provided")
            return "ERROR", 400

    items = db.execute("SELECT item_id, name, price FROM items").fetchall()
    print("Fetched items from database:", [dict(item) for item in items])  # Debug print

    connection.close()  # Close the connection to prevent resource leakage
    return render_template('menu.html', items=items)



@app.route('/cart')
def cart():
    connection = sqlite3.connect('menu.db', check_same_thread=False)
    connection.row_factory = sqlite3.Row
    db = connection.cursor()
    
    # Select only items in the cart associated with this session
    cart_items = db.execute("""
        SELECT items.name, items.price 
        FROM cart 
        INNER JOIN items ON cart.item_id = items.item_id
        WHERE cart.session_id = ?
    """, (session['session_id'],)).fetchall()

    # Calculate total price
    total_price = sum(item['price'] for item in cart_items)
    connection.close()

    return render_template('cart.html', cart=cart_items, total_price=total_price)


@app.route('/post_data', methods=["POST"])
def post_data():
    global current_countdown
    
    if request.is_json:
        data = request.get_json()
        current_countdown = data.get("timeleft")
        print(f"Received timeleft: {current_countdown}")
        return jsonify({"success": True, "timeleft": current_countdown}), 200
    return jsonify({"error": "Invalid data format"}), 400

@app.route('/timeleft')
def timeleft():
    return render_template('timeleft.html', countdown=current_countdown)


if __name__ == '__main__':
    
    app.run(debug=True) 