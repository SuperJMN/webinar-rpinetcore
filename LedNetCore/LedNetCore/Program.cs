using System;
using Unosquare.RaspberryIO;
using Unosquare.RaspberryIO.Gpio;

namespace LedNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            TestLedBlinking();
        }

        public static void TestLedBlinking()
        {
            var blinkingPin = Pi.Gpio.Pin00;

            // Configure the pin as an output
            blinkingPin.PinMode = GpioPinDriveMode.Output;

            // perform writes to the pin by toggling the isOn variable
            var isOn = false;
            for (var i = 0; i < 30; i++)
            {
                isOn = !isOn;
                blinkingPin.Write(isOn);
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
