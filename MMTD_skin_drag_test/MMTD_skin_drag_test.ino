#include <Servo.h>

Servo servoXY;
Servo servoZ;

int servoXYPin = 9;
int servoZPin = 10;

int angleXY = 85;
int angleZ = 90;

static int angleXYmin = 40;
static int angleXYmax = 130;
static int angleZmin = 10;
static int angleZmax = 170;

bool stringComplete = false;
char inData[100];
int dataIdx = 0;

void setup() {
  // put your setup code here, to run once:
  servoXY.attach(servoXYPin);
  servoZ.attach(servoZPin);
  Serial.begin(115200);
  while(! Serial);
  Serial.println("Ready for command...");
  servoXY.write(angleXY);
  servoZ.write(angleZ);
}

void loop() {
  // put your main code here, to run repeatedly:
  while(Serial.available() && stringComplete == false)
  {
    char inChar = Serial.read();
    inData[dataIdx++] = inChar;
    Serial.print(inChar);
    Serial.flush();

    if(inChar == '\n')
    {
      stringComplete = true;
    }
  }
  loopSerial();
}

void loopSerial()
{
  if(stringComplete)
  {    
    switch(inData[0])
    {
      case 'x':
        if(dataIdx == 3)
        {
          angleXY = (int)inData[1] - 48;
        }
        else if(dataIdx == 4)
        {
          angleXY = 10*((int)inData[1] - 48) + (int)inData[2] - 48;
        }
        else if(dataIdx == 5)
        {
          angleXY = 100*((int)inData[1] - 48) + 10*((int)inData[2] - 48) + (int)inData[3] - 48;
        }
        if(angleXY < angleXYmin)
        {
          angleXY = angleXYmin;
        }
        if(angleXY > angleXYmax)
        {
          angleXY = angleXYmax;
        }
        Serial.print("angleXY: ");
        Serial.println(angleXY);
        Serial.flush();
        servoXY.write(angleXY);
        break;
      case 'z':
        if(dataIdx == 3)
        {
          angleZ = (int)inData[1] - 48;
        }
        else if(dataIdx == 4)
        {
          angleZ = 10*((int)inData[1] - 48) + (int)inData[2] - 48;
        }
        else if(dataIdx == 5)
        {
          angleZ = 100*((int)inData[1] - 48) + 10*((int)inData[2] - 48) + (int)inData[3] - 48;
        }
        if(angleZ < angleZmin)
        {
          angleZ = angleZmin;
        }
        if(angleZ > angleZmax)
        {
          angleZ = angleZmax;
        }
        Serial.print("angleZ: ");
        Serial.println(angleZ);
        Serial.flush();
        servoZ.write(angleZ);
        break;
      default:
        break;
    }
    int tmpIdx = 0;
    while(tmpIdx < dataIdx)
    {
      inData[tmpIdx++] = NULL;
    }
    dataIdx = 0;
    stringComplete = false; 
  }
}
