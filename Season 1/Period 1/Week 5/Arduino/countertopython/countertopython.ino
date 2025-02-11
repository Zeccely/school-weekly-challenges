#include <ArduinoJson.h>

void setup() {
  Serial.begin(9600);          // Start serial communication at 9600 baud
}

void loop() {
  // Create a StaticJsonDocument object
  

  // Add key-value pairs to the document
  doc["lightLevel"] = 777;
  doc["time"] = "9 dec 2024";

  // Serialize the JSON document to a string
  String jsonData;
  serializeJson(doc, jsonData);

  // Print the JSON string to the Serial Monitor
  Serial.println(jsonData);
}
StaticJsonDocument<200> doc;