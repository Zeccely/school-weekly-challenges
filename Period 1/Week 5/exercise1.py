from flask import Flask
from datetime import datetime
import random
from flask import render_template 

app= Flask(__name__)

def time():  
    time = datetime.now()                       # no parameter means nothing is needed to call this function
    return time


def light_level():                  #a parameter is something you give to a function to use
    lightlist=[]
    while len(lightlist) < 10:
        number = random.randint(1,1000)
        lightlist.append(number)
    return lightlist

@app.route("/")
def get_info():
    lightLevel = light_level()
    lls = str(lightLevel)
    t = time()
    ts = str(t)
    return render_template("time_light.html", time = ts, light = lls)

app.run(port=5000)