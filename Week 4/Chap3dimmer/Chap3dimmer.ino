int val=0;
int redlight= 6;
int potmeter=14;
void setup() {
  // put your setup code here, to run once:
  pinMode(redlight, OUTPUT);
  pinMode(arrow, INPUT);
  Serial.begin(9600); //open this port to put values

}

void loop() {
  // put your main code here, to run repeatedly:
  val = analogRead(potmeter); //read analog input from the potmeter pin
  val = map(val, 0, 1023, 0, 255); // change the values to match the lightpin, 0 to 255
  Serial.println(val); //I wanna see it

  analogWrite(redlight, val); //puts the value in the pwm lightpin, hard to understand the "triangle wave"
  
}

