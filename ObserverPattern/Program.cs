using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation station = new WeatherStation(37);

            PhoneDisplay display1 = new PhoneDisplay(station);
            PhoneDisplay display2 = new PhoneDisplay(station);
            PhoneDisplay display3 = new PhoneDisplay(station);

            station.Add(display1);
            station.Add(display2);
            station.Add(display3);

            display1.Display();
            display2.Display();
            display3.Display();
            station.Temperature = 40;
            display1.Display();
            display2.Display();
            display3.Display();
        }
    }
}
