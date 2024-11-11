int count = 0;
int thisnumber= 0;
int previousnumber= 0;
int redlight= 4;
int buttonentry = 9;
int buttonexit = 8;

void setup() {
  // put your setup code here, to run once:
  pinMode(buttonentry, INPUT_PULLUP);
  pinMode(buttonexit, INPUT_PULLUP);
  pinMode(redlight, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  int buttonState1; // is it pressed in or not
  int buttonState2; // is it pressed in or not
  buttonState1 = digitalRead(buttonentry);
  buttonState2 = digitalRead(buttonexit);

    if (buttonState1 == LOW) {   //if it is pressed in
    digitalWrite(redlight, HIGH); //give a sign
    thisnumber = 1;               //condition for entry 
    }
    else if (buttonState2 == LOW) { // if it is pressed in
    digitalWrite(redlight, HIGH); //give a sign
    thisnumber = 2;               // condition for exit
    }
    else {
      digitalWrite(redlight, LOW); //no signs
      thisnumber = 0;           // condition for no button pressed in
    }
    if (thisnumber != previousnumber) { //if the condition changes
      if (thisnumber == 1) {          // if the condition is entry
        count = count+1;              // add one
      Serial.println(count);          // let me see the one
      }
      if (thisnumber == 2 && count>0) { //if the condition is exit and not 0
        count= count-1;                 // remove one
      Serial.println(count);            // let me see
      }
    previousnumber = thisnumber;       //after button pressed the previous number is updated
    delay(400);                        //no crazy numbers on screen
  }
}
