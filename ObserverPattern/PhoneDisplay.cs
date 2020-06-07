using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class PhoneDisplay : IObserver, IDisplay
    {
        private WeatherStation station;
        public int Temperature { get; set; }

        public PhoneDisplay(WeatherStation weatherStation)
        {
            this.station = weatherStation;
        }

        public void Update()
        {
            this.Temperature = this.station.Temperature;
        }

        public void Display()
        {
            Console.WriteLine("The temperature is " + this.Temperature + "°C");
        }
    }
}
