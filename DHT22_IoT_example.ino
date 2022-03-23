#include <Wire.h>
#include <LiquidCrystal_I2C.h>
#include <SoftwareSerial.h>
SoftwareSerial esp8266(10,11); 
#include <DHT.h>
#define DEBUG 1 
#define DHTPIN 2     // 設定DHT的接腳
#define _ledpin 13 

//#define DHTTYPE DHT11   // DHT 11 定義DHT的類型為DHT11
#define DHTTYPE DHT22   // DHT 22  (AM2302), AM2321
 
LiquidCrystal_I2C lcd(0x27, 2, 1, 0, 4, 5, 6, 7, 3, POSITIVE);
DHT dht(DHTPIN, DHTTYPE);  
#define _baudrate   9600

//*-- IoT Information
String SSID="ASUS_LAB1"; //[無線網路熱點名稱]
String PASS="ASUSASUS"; //[無線網路連線密碼]
#define IP "184.106.153.149" // ThingSpeak IP Address: 184.106.153.149
// 使用 GET 傳送資料的格式
// GET /update?key=[THINGSPEAK_(Write)API_KEY]&field1=[data 1]&filed2=[data 2]...;
String GET = "GET /update?key=XXXXXXXXXXXXXX";//改成使用者的Key

  String get_ESP8266_response() 
  {  //取得 ESP8266 的回應字串
  String str="";  //儲存接收到的回應字串
  char c;  //儲存接收到的回應字元
  while (esp8266.available()) 
  {  //若軟體序列埠接收緩衝器還有資料
    c=esp8266.read();  //必須放入宣告為 char 之變數 (才會轉成字元)
    str.concat(c);  //串接回應字元 
    delay(10);  //務必要延遲, 否則太快
    }
  str.trim();  //去除頭尾空白字元
  return str;
  } 
  
const int SMARTCONFIG_PIN=5;
const int WEBCONFIG_PIN=4; //Pin to switch configuration or working mode
const int MAX_PAGE_NAME_LEN=48;  //buffer size
char buffer[MAX_PAGE_NAME_LEN + 1]; //store page_name/ssid/pwd
int mode; //store current mode(LOW=configuration, HIGH=working)

void setup() 
{
  pinMode(WEBCONFIG_PIN, INPUT_PULLUP);
  pinMode(SMARTCONFIG_PIN, INPUT_PULLUP);

  esp8266.begin( _baudrate );
  Serial.begin( _baudrate );
  
  lcd.begin(16, 2);      // 初始化 LCD，一行 16 的字元，共 2 行，預設開啟背光
  // 閃爍
  lcd.backlight(); // 開啟背光
  delay(200);
  lcd.noBacklight(); // 關閉背光
  delay(200);
  lcd.backlight();
  lcd.setCursor(0, 0); // 設定游標位置在第一行行首
  lcd.print("Hello, world!");
  lcd.setCursor(0, 1); // 設定游標位置在第二行行首
  lcd.print("DHT sensor test!!");
  connectWiFi();   
 }

void loop() 
{
     float hh, tt;
     hh=dht.readHumidity();
     tt=dht.readTemperature();
    // 確認取回的溫濕度數據可用
    if (isnan(hh) || isnan(tt))
    {
        Serial.println( "Failed to read form DHT11" );
        lcd.setCursor(0, 0);
        lcd.clear();
        lcd.print("Failed to read from DHT11");
        lcd.setCursor(0, 1);    
        lcd.print("                "); 
        //digitalWrite( _ledpin, HIGH);
        delay(2000);
    }
    else
    {
      String HH, TT;
      HH = String(hh,1);
      TT = String(tt, 1);
      for(int i=0; i<2; i++)
      {
        digitalWrite(_ledpin, HIGH);
        delay(1000);
        digitalWrite(_ledpin, LOW);
        delay(500);
      }

       lcd.home();
       lcd.clear();
       lcd.print("Humidity:");       
       lcd.print((int)dht.readHumidity());       
       lcd.print("%");       
       lcd.setCursor(0, 1); 
       lcd.print("Temp:");       
       lcd.print((float)dht.readTemperature(), 1);   
       lcd.write(0xdf);  //
       lcd.print("C"); 
        #ifdef DEBUG
            Serial.print("Humidity: "); 
            Serial.print( HH );
            Serial.print(" %\t");
            Serial.print("Temperature: "); 
            Serial.print( TT );
            Serial.println(" *C\t");
        #endif
        /*sendDebug( "AT+CIPCLOSE");
        String cmd = "AT+CIPSTATUS";
        sendDebug("AT+CIPSTATUS");
        esp8266.setTimeout(5000);
        if(esp8266.find("STATUS:5"))
        {
            sendDebug("AT+RST");
            delay(5000);
        }*/
        updateDHT( TT, HH );
        delay(15000);
    }
}

void updateDHT( String T, String H )
{
    // 設定 ESP8266 作為 Client 端
    String cmd = "AT+CIPSTART=\"TCP\",\"";
    cmd += IP;
    cmd += "\",80";
    sendDebug(cmd);
    esp8266.setTimeout(10000);
    if(esp8266.find("OK"))
    {
      cmd = GET + "&field1=" + T + "&field2=" + H +"\r\n";
      esp8266.print( "AT+CIPSEND=" );
      esp8266.println( cmd.length() );
      esp8266.setTimeout(5000);
      if(esp8266.find( ">" ) )
      {
        Serial.print(">");
        Serial.print(cmd);
        esp8266.print(cmd);
      }
    }
    else
    {
        sendDebug( "AT+CIPCLOSE" );
        Serial.println( "RECEIVED: Error\nExit1" );
        return;
     }
    esp8266.setTimeout(5000);
    if( esp8266.find("OK") )
    {
        Serial.println( "RECEIVED: OK" );
    }
    else
    {
        Serial.println( "RECEIVED: Error\nExit2" );
        sendDebug( "AT+CIPCLOSE" );
    }
}
void sendDebug(String cmd)
{
    Serial.print("SEND: ");
    Serial.println(cmd);
    esp8266.println(cmd);
} 
 
boolean connectWiFi()
{
    sendDebug("AT+RST");
    delay(3000);
    while(esp8266.available())
      Serial.print((char)esp8266.read());
    Serial.println();
    sendDebug("AT+CWMODE=1");
    delay(3000);
    while(esp8266.available())
      Serial.print((char)esp8266.read());
    Serial.println();
    sendDebug("AT+CIPMUX=0");
    delay(3000);
    while(esp8266.available())
    {
      Serial.print((char)esp8266.read());
      delay(10);
    }
    Serial.println();
    String cmd ="AT+CWJAP=\"" + SSID + "\",\"" + PASS +"\""; 
    sendDebug(cmd);
    delay(5000);
    while(1)
    {
      if(esp8266.find("WIFI CONNECT"))
      {
        while(esp8266.available())
        {
          esp8266.read();
          delay(10);
        }
        Serial.println("AP connected");
        break;
      }
      else
      {
            String cmd ="AT+CWJAP=\"" + SSID + "\",\"" + PASS +"\""; 
            sendDebug(cmd);
            delay(10000);
      }
    }
} 

String sendData(String command, const int timeout, boolean debug) {
  String response="";
  esp8266.print(command); // send the read character to the esp8266
  long int time=millis();
  while ((time+timeout) > millis()) {
    while(esp8266.available()) {
      // The esp has data so display its output to the serial window
      char c=esp8266.read(); // read the next character.
      response += c;
      } 
    }
  if (debug) {Serial.print(response);}
  return response;
  }
