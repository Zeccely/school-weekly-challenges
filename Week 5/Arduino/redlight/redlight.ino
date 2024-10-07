const int PIN_LED = 4;  // Define the I/O pin connected to the LED

void setup() {
  Serial.begin(9600);          // Start serial communication at 9600 baud
  pinMode(PIN_LED, OUTPUT);    // Set the I/O pin connected to the LED as an output
}

void loop() {
  String cmd;
  if (Serial.available()) {    // Check if data has arrived on the serial port
    cmd = Serial.readStringUntil('\n');  // Read the incoming command
    if (cmd == "LedOn") {
      digitalWrite(PIN_LED, HIGH);  // Turn the LED on
    } else if (cmd == "LedOff") {
      digitalWrite(PIN_LED, LOW);   // Turn the LED off
    }
  }
}
