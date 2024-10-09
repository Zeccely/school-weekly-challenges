import serial
import time

ser = serial.Serial("COM5", baudrate=9600, timeout=0.5)

response = True
while response:
    bytes_serial = ser.write(b"Command\n")
    data = ser.readline().decode().strip()

    print(data)
    @app.route("/arduinodata", methods=["POST"])
