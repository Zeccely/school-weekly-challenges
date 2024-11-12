int val = 0;
int redlight = 4
int greenlight = 5
int bluelight = 6
int yellowlight = 7
int potmeter = 14


void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600); //this is necessary to see the print
  pinMode(potmeter, INPUT);
  pinMode(yellowlight, OUTPUT);
  pinMode(bluelight, OUTPUT);
  pinMode(greenlight, OUTPUT);
  pinMode(redlight, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  val = analogRead(potmeter);  //I wanna see the values
  val = map(val, 0, 1023, 0, 100); //mapping the values so its not from 1023 but 0 to 100
  if (val < 25) {
    digitalWrite (bluelight, LOW);
    digitalWrite (greenlight, LOW);
    digitalWrite (redlight, LOW);
    digitalWrite (yellowlight, HIGH);
  }
  if ((val > 25) && (val < 50)) {
    digitalWrite (redlight, LOW);
    digitalWrite (greenlight, LOW);
    digitalWrite (bluelight, HIGH);
    digitalWrite (yellowlight, LOW);
       
  }
  if ((val > 50) && (val < 75)) {
    digitalWrite (redlight, LOW);
    digitalWrite (greenlight, HIGH);
    digitalWrite (bluelight, LOW);
    digitalWrite (yellowlight, LOW);
  }
  if (val > 75) {
    digitalWrite (redlight, HIGH);
    digitalWrite (greenlight, LOW);
    digitalWrite (bluelight, LOW);
    digitalWrite (yellowlight, LOW);
    
  }
  
  Serial.println (val); //I wanna see the values

  delay(500); //delay so I can see them slower
}

