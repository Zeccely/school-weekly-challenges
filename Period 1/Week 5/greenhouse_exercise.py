from datetime import datetime
from flask import Flask
from flask import render_template
import random

app= Flask(__name__)

infolist={}

def light_level():
    light_lv = round(random.uniform(1,1000))
    light_str = str(light_lv)
    return light_str

def time_day():
    return str(datetime.now().replace(microsecond=0))

def time():
    return str(datetime.now().hour) + ":" + str(datetime.now().minute) + ":" + str(datetime.now().second)

@app.route("/")

def get_info():
    light_lev= light_level()
    current_time = time_day()
    current_hour = time()
    infolist.update({light_lev : current_hour})
    return render_template ("exercise1.html", time_day = current_time, light = light_lev, hourminsec = current_hour, test = infolist )

app.run(port=5000)