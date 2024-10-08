
int button = 9;
int temperatureA2 = 15;
int humidity = 12;
int brightnessA1 = 16;
int state= 0;
int statechanger = 0;
int NTC_R25 = 10000;
int NTC_MATERIAL_CONSTANT = 3950;
unsigned long previouspress= 0; //nillis gets really large numbers 

  float get_temperature(){

    float temperature,resistance;
    int value;

    value = analogRead(temperatureA2);
    resistance   = (float)value * NTC_R25/(1024 - value); // Calculate resistance
    /* Calculate the temperature according to the following formula. */
    temperature  = 1/(log(resistance/NTC_R25)/NTC_MATERIAL_CONSTANT+1/298.15)-273.15;
    return temperature; // Used the temperature converter on the richshield example to get celcius instead of volts? values
  }
  float get_light(){
    // read the analog value
    int sensorValue = analogRead(brightnessA1);
    float resistance_sensor;
    // and convert to resistance in Kohms
    resistance_sensor=(float)(1023-sensorValue)*10/sensorValue;
    float lux;
    lux = 325 * pow(resistance_sensor, -1.4);
    return lux;
  }
void setup() {
  // put your setup code here, to run once:
  pinMode(button, INPUT_PULLUP); //wake up button
  pinMode(temperatureA2, INPUT); // wake up temperature sensor
  pinMode(humidity, INPUT); // wake up humidity sensor
  pinMode(brightnessA1, INPUT); // wake up light sensor
  
  state = 0;
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  int buttonpress;
  int valu;
  buttonpress = digitalRead(button);
  int temp;
  int light;
  unsigned long newpress = millis();
  int sensorInterval= 1000;
  int buttonInterval = 200;


  if (buttonpress == LOW) {
    if (newpress-previouspress  >= buttonInterval) {
    state = state + 1;
    previouspress = newpress;
    Serial.println("I felt that");
    }
    
  }

    if (state == 1 ){
     if (newpress-previouspress  >= sensorInterval){
      
      temp = get_temperature();
      Serial.println(temp);
      previouspress = newpress; 
     }
   
    
  }
    if (state == 2){
      if (newpress-previouspress  >= sensorInterval){
        valu= digitalRead(humidity);
        Serial.println(valu);
        previouspress = newpress;
      }    
        
    
  }
    if (state == 3){
      if (newpress-previouspress  >= sensorInterval){
      light = get_light();
      Serial.println(light);
      previouspress = newpress;
      }
      
  }

    if (state == 4){
      if (newpress-previouspress  >= sensorInterval){
      state = 1;
      previouspress = newpress;
      }
      
        
  } 

}