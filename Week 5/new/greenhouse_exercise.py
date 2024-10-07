from datetime import datetime
from flask import Flask
from flask import render_template
import random
from flask import request, redirect
import serial 
import requests

app= Flask(__name__)

infolist={}

ser = serial.Serial("COM5", baudrate=9600, timeout=1)

def light_level():
    light_lv = round(random.uniform(1,1000))
    light_str = str(light_lv)
    return light_str


def time_day():
    return str(datetime.now().replace(microsecond=0))

def time():
    return str(datetime.now().hour) + ":" + str(datetime.now().minute)

@app.route("/")
def get_info():
    current_time = time_day()
    bytes_serial = ser.inWaiting()

    # print(bytes_serial)

    # Only read if data is available
    if bytes_serial > 0:
        # Read the byte array, decode it to a string, and remove newline characters
        data = ser.readline()
        
        print(data)

        requests.post("http://127.0.0.1:5000/addLevel", json = data )
    
    
    return render_template ("exercise1.html", time_day= current_time, test=infolist)

@app.route("/addLevel", methods=["POST"])
def post_info():
    thing=request.get_json()
    light_lev = thing['lightLevel']
    current_hour = thing['time']
    infolist.update({light_lev : current_hour})

    return redirect('/')


app.run(port=5000)