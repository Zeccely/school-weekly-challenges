from datetime import datetime
from flask import Flask
from flask import render_template
import random
from flask import request, redirect
import serial 
import requests
import json

app= Flask(__name__)

infolist=[]         #make a list for me
ser = serial.Serial("COM5", baudrate=9600, timeout=2) # read the arduino serial input


def get_time_day():         # this is a function that shows the date and time
    return str(datetime.now().replace(microsecond=0))

def get_time():         #this is a function that shows the time
    return str(datetime.now().hour) + ":" + str(datetime.now().minute) + ":" + str(datetime.now().second)

@app.route("/")         #defining the get route
def get_info():         #step to define get route
    current_time = get_time_day()   #this variable will go onto flask template.
    timeonly = get_time()           # same here
    data = json.loads(ser.readline().decode().strip())  #the data variable for template needs to be a json file. read the serial input decode strip and jsonify it
    data["Time"]=timeonly           #this is necessary to make timestamps on the template. in data there is a time in template relate it to timeonly variable
    requests.post("http://127.0.0.1:5000/addData", json = data ) #post the json data 
    
    return render_template ("exercise1.html", time = timeonly, time_day= current_time, test=infolist ) #fisplay all the data with the placeholders and the loop. test is where the jsonfiles go

@app.route("/addData", methods=["POST"]) #defining post route
def post_info():
    thing=request.get_json()    #make a thing. this thing gets the json
    print(thing)                #debugger
    infolist.append(thing)      #add thing into that empty list. I need it for the template
    print(infolist)             #debugger!
    return "", 204              # I found a way for the website to respond because I had many issues with rendering the template. at some point the code wouldn't render at all


app.run(port=5000, use_reloader=False)