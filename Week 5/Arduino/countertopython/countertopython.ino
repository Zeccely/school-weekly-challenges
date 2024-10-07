const int PIN_LED = 4;  // Define the I/O pin connected to the LED

void setup() {
  Serial.begin(9600);          // Start serial communication at 9600 baud
}

void loop() {
  delay(500);
  // Serial.println("Arduino Ready"); // Send this every loop for testing
  Serial.println(5);
}
