import serial
import requests
import time

ser = serial.Serial("COM3", baudrate=9600, timeout=1)
url = "http://127.0.0.1:5000/post_data"

def read_arduino():
    bytes_serial = ser.inWaiting()
    if bytes_serial > 0:
        ser_data = ser.readline().decode().strip()
        try:
            timeleft = int(ser_data)  
            formated_data = {"timeleft": timeleft}
            print(formated_data)  
            
            response = requests.post(url, json=formated_data)
            print(response.text)  
        except ValueError:
            print("Invalid data received:", ser_data)

# Continuously reads the data from Arduino in an endless loop
while True:
    read_arduino()
    time.sleep(1)  # Add a small delay to prevent overloading the serial buffer
