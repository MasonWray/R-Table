/*
 Name:		firmware.ino
 Created:	7/20/2022 8:32:34 PM
 Author:	Mason Wray
*/
#include <Arduino.h>

#define STEP_PIN 10
#define DIR_PIN 9
#define M0_PIN 12
#define M1_PIN 11
#define STEPS 200
#define PERIOD 300

#define BGSTEP 500
#define SMSTEP 10

int steps_rev;
uint16_t position;
uint16_t target;
uint32_t timer;

enum dir_e
{
	CLOCKWISE,
	COUNTERCLOCKWISE,
};

void setup() {
	pinMode(STEP_PIN, OUTPUT);
	pinMode(DIR_PIN, OUTPUT);
	digitalWrite(DIR_PIN, LOW);
	steps_rev = STEPS * 16;
	timer = micros();

	// Set microstepping to 1/32
	pinMode(M0_PIN, OUTPUT);
	pinMode(M1_PIN, OUTPUT);
	digitalWrite(M0_PIN, HIGH);
	digitalWrite(M1_PIN, HIGH);
	position = 0;
	target = 0;
	Serial.begin(9600);
}

void loop() {
	while (Serial.available())
	{
		char c = Serial.read();
		switch (c)
		{
		case 'L':
			target = (target - BGSTEP) <= 0 ? 0 : target - BGSTEP;
			break;
		case 'l':
			target = (target - SMSTEP) <= 0 ? 0 : target - SMSTEP;
			break;
		case 'r':
			target = (target + SMSTEP) > steps_rev ? steps_rev : target + SMSTEP;
			break;
		case 'R':
			target = (target + BGSTEP) > steps_rev ? steps_rev : target + BGSTEP;
			break;
		}
	}

	if (target > position)
	{
		digitalWrite(DIR_PIN, LOW);
		unsigned int i = 0;
		while (target > position)
		{
			step();
			delayMicroseconds(getDuration(i, target - position));
			position++;
			i++;
		}
	}

	if (target < position)
	{
		digitalWrite(DIR_PIN, HIGH);
		unsigned int j = 0;
		while (target < position)
		{
			step();
			delayMicroseconds(getDuration(j, position - target));
			position--;
			j++;
		}
	}
}

unsigned int getDuration(int current, int remaining)
{
	double fromEnd = 18000.0 * (1.0 / (1.0 + (remaining / 6.0) * (remaining / 6.0)));
	double fromStart = 18000.0 * (1.0 / (1.0 + (current / 6.0) * (current / 6.0)));
	double fromStart = 18000.0 * (1.0 / (1.0 + (current / 6.0) * (current / 6.0)));
	Serial.println(fromEnd);
	int pred = 1600 - (current * 20);
	return 10 + (fromEnd > fromStart ? fromEnd : fromStart);
}

void step()
{
	digitalWrite(STEP_PIN, HIGH);
	delayMicroseconds(PERIOD);
	digitalWrite(STEP_PIN, LOW);

}

void dir(dir_e d)
{
	switch (d)
	{
	case CLOCKWISE:
		digitalWrite(DIR_PIN, LOW);
		break;
	case COUNTERCLOCKWISE:
		digitalWrite(DIR_PIN, HIGH);
		break;
	}
}

void move(uint16_t target)
{
	uint8_t interval = 200;
	uint32_t t = micros();
	if (target > steps_rev) {
		target = steps_rev;
	}
	while (position < target) {
		dir(CLOCKWISE);
		step();
		delayMicroseconds(interval);
		position++;
	}
	while (position > target) {
		dir(COUNTERCLOCKWISE);
		step();
		delayMicroseconds(interval);
		position--;
	}
}

void sweep(uint16_t target)
{
	/*if (target > steps_rev) { target = steps_rev; }
	if()*/
}

