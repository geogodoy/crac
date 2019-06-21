#include <Arduino.h>
#include <Servo.h>
#include <stdio.h>
#include <ESP8266WiFi.h>
#include <ESP8266WiFiMulti.h>
#include <ESP8266HTTPClient.h>
#include <WiFiClient.h>
#include <ArduinoJson.h>

// servos pin definition
#define SERVO_MOTOR_CLAW D7
#define SERVO_MOTOR_BASE D8
#define SERVO_MOTOR_RIGHT D6
#define SERVO_MOTOR_LEFT D5

Servo base, right, left, claw;
int stepCount = 0;
bool isFinished = false;

// API endpoint
const char *apiEndpoint = "http://COLOCA O IP E A PORTA AQUI/api/";

// wifi stuff
const char *ssid = "SONYVAIO7161";
const char *password = ":9O7873w";

ESP8266WiFiMulti WiFiMulti;

void setup()
{

    // inicializa serial
    Serial.begin(115200);

    // iniciliza servos e coloca na posicao inicial
    base.attach(SERVO_MOTOR_BASE);
    claw.attach(SERVO_MOTOR_CLAW);
    right.attach(SERVO_MOTOR_RIGHT);
    left.attach(SERVO_MOTOR_LEFT);
    base.write(0);
    claw.write(0);
    right.write(0);
    left.write(0);

    // inicializa wifi

    Serial.println();
    Serial.println();
    Serial.println();

    for (uint8_t t = 4; t > 0; t--)
    {
        Serial.printf("[SETUP] WAIT %d...\n", t);
        Serial.flush();
        delay(1000);
    }

    // conecta na rede wifi
    WiFi.mode(WIFI_STA);
    WiFiMulti.addAP(ssid, password);
}

void loop()
{

    // verifica se a execucao finalizou e vaza e ja acabou
    if (isFinished)
    {
        return;
    }

    // se wifi nao ta conectado vaza louco tbm
    if ((WiFiMulti.run() != WL_CONNECTED))
    {
        return;
    }

    // DEPOIS IDENTA ESSA PORRA TA DE DANDO TOQUE!!!!

    //incrementa passo
    stepCount++;

    WiFiClient client;
    HTTPClient http;
    String addressToRequest = apiEndpoint + stepCount;

    Serial.print("[HTTP] begin...\n");
    // HTTP
    if (!http.begin(client, addressToRequest))
    {
        return;
    }

    Serial.print("[HTTP] GET...\n");
    Serial.print(addressToRequest);

    // start connection and send HTTP header
    int httpCode = http.GET();

    // httpCode will be negative on error
    if (httpCode < 0)
    {
        Serial.printf("[HTTP] GET... failed, error: %s\n", http.errorToString(httpCode).c_str());
        delay(2000);
        return;
    }

    // HTTP header has been send and Server response header has been handled
    Serial.printf("[HTTP] GET... code: %d\n", httpCode);

    // verifica se api do demonho respondu com os passos demoniacos
    if (httpCode != HTTP_CODE_OK)
    {
        delay(2000);
        return;
    }

    // retorno da API REST
    // api deve retornar um json no formato {"passos":[90,90,90,90]}
    // posicao 0 do array servo right
    // posicao 1 do array servo left
    // posicao 2 do array servo base
    // posicao 3 do array servo claw

    String payload = http.getString();
    Serial.println(payload);

    // macumbaria pra deserializar o objeto json retornado pela api
    // Allocate JsonBuffer
    // Use arduinojson.org/assistant to compute the capacity.
    const size_t capacity = JSON_OBJECT_SIZE(3) + JSON_ARRAY_SIZE(2) + 60;

    DynamicJsonDocument doc(capacity);
    DeserializationError error = deserializeJson(doc, payload);

    if (error)
    {
        Serial.println(F("Parsing failed!"));
        return;
    }

    // verifica se o array de passos veio com menos de 4 posicoes, significa que nao tem mais passos para o arduino pedir
    if (sizeof(doc["passos"]) < 4)
    {
        isFinished = true;
        return;
    }
    // escreve passos nos servos
    right.write(doc["passos"][0].as<int>());
    left.write(doc["passos"][1].as<int>());
    base.write(doc["passos"][2].as<int>());
    claw.write(doc["passos"][3].as<int>());

    http.end(); //Close connection

    // aguarda 2s antes de solitar um novo passo
    delay(2000);
}
