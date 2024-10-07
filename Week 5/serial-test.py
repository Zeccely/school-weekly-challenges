import serial

ser = serial.Serial("COM8", baudrate=9600, timeout=1)

while True:
    user_input = input("Enter 1 to turn the LED ON, 2 to turn the LED OFF, q to quit: ")

    if user_input == "1":
        ser.write("LedOn".encode())
        print("LED turned ON")
    elif user_input == "2":
        ser.write("LedOff".encode())
        print("LED turned OFF")
    elif user_input.lower() == "q":
        print("Exiting program.")
        break
    else:
        print("Invalid input, please enter 1, 2, or q")

ser.close()
