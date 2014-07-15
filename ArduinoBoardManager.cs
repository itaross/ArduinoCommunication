using System;

namespace ArduinoCommunication
{
    public class ArduinoBoardManager
    {
        private const int numberOfPins = 13;
        private readonly Pin[] arduinoPins;

        public ArduinoBoardManager()
        {
            arduinoPins = new Pin[numberOfPins];

            for (uint i = 0; i < numberOfPins; i++)
            {
                arduinoPins[i] = new Pin(i, "pin_" + i, Pin.pinMode.INPUT_PIN);
            }
        }

        public Pin GetPin(int pinNumber)
        {
            if (isValidPin(pinNumber))
            {
                return arduinoPins[pinNumber];
            }
            return null;
        }


        public String ChangePinModeCmd(int pinNumber, Pin.pinMode mode)
        {
            if (isValidPin(pinNumber))
            {
                arduinoPins[pinNumber].setMode(mode);
                return formatCmd("PIN_" + pinNumber + "_M_" + arduinoPins[pinNumber].getMode());
            }
            return "";
        }


        public String writeDigitalPinValue(int pinNumber, bool value)
        {
            if (isValidPin(pinNumber))
            {
                return formatCmd("PIN_" + pinNumber + "_WD_" + (value ? '1' : '0'));
            }
            return "";
        }


        public String writeAnalogPinValue(int pinNumber, int value)
        {
            //1024 is MAX_VAL                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
            if (isValidPin(pinNumber) && (value >= 0 && value <= 1024))
            {
                return formatCmd("PIN_" + pinNumber + "_WA_" + value);
            }
            return "";
        }

        public bool isValidPin(int pinNumber)
        {
            if (pinNumber <= numberOfPins && pinNumber >= 0)
            {
                return true;
            }
            return false;
        }


        private String formatCmd(String cmd)
        {
            return (char) 0x16 + cmd + (char) 0x0d;
        }
    }
}