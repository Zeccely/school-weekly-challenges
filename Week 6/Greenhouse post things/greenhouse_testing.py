from datetime import datetime
from flask import Flask
from flask import render_template
import random
from flask import request, redirect
import serial 
import requests
import json

app= Flask(__name__)

infolist=[]
ser = serial.Serial("COM5", baudrate=9600, timeout=2)


def get_time_day():
    return str(datetime.now().replace(microsecond=0))

def get_time():
    return str(datetime.now().hour) + ":" + str(datetime.now().minute) + ":" + str(datetime.now().second)

@app.route("/")
def get_info():
    current_time = get_time_day()
    timeonly = get_time()
    data = json.loads(ser.readline().decode().strip())
    data["Time"]=timeonly
    requests.post("http://127.0.0.1:5000/addData", json = data )
    
    return render_template ("exercise1.html", time = timeonly, time_day= current_time, test=infolist )

@app.route("/addData", methods=["POST"])
def post_info():
    thing=request.get_json()
    print(thing)
    infolist.append(thing)
    print(infolist)
    return "", 204


app.run(port=5000, use_reloader=False)