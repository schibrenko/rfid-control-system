#include <SPI.h>
#include <RFID.h>

#define SS_PIN 10
#define RST_PIN 9

RFID rfid(SS_PIN, RST_PIN); 

// Setup variables:
    int serNum0;
    int serNum1;
    int serNum2;
    int serNum3;
    int serNum4;
int incomingByte=0;
void setup()
{ 
  Serial.begin(9600);
  SPI.begin(); 
  rfid.init();
  
}

void loop()
{
   if (Serial.available() > 0) {  //если есть доступные данные
        incomingByte = Serial.read();
        if(incomingByte=='1')
        {
          Serial.println("Device");
        }
       else if(incomingByte=='2')
        {
          serNum0=0;
          serNum1=0;
          serNum2=0;
          serNum3=0;
          serNum4=0;
        }
   }
  
  
    if (rfid.isCard()) {
        if (rfid.readCardSerial()) {
            if (rfid.serNum[0] != serNum0
                && rfid.serNum[1] != serNum1
                && rfid.serNum[2] != serNum2
                && rfid.serNum[3] != serNum3
                && rfid.serNum[4] != serNum4
            ) {
                
               
              
                serNum0 = rfid.serNum[0];
                serNum1 = rfid.serNum[1];
                serNum2 = rfid.serNum[2];
                serNum3 = rfid.serNum[3];
                serNum4 = rfid.serNum[4];
                
                
                Serial.print(rfid.serNum[0],HEX);
                Serial.print(rfid.serNum[1],HEX);
                Serial.print(rfid.serNum[2],HEX);
                Serial.print(rfid.serNum[3],HEX);
                Serial.print(rfid.serNum[4],HEX);
                Serial.println("");
             } 
          }
    }
    
    rfid.halt();
}
