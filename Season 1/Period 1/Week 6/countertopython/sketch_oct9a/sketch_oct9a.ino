
void setup() {
  Serial.begin(9600);            // Start serial communication at 9600 baud

}

void loop() {
  String cmd;
  if (Serial.available()) {                  // Check if data is available to read
    cmd = Serial.readStringUntil('\n');            //needed this sketch to learn send the serial data
