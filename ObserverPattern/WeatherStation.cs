using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class WeatherStation : IObservable
    {
        private int temperature;

        public int Temperature
        {
            get
            {
                return temperature;
            }

            set
            {
                this.temperature = value;
                Notify();
            }
        }

        public List<IObserver> Observers { get; }

        public WeatherStation(int temp)
        {
            this.Observers = new List<IObserver>();
            this.temperature = temp;
        }

        public void Add(IObserver observer)
        {
            this.Observers.Add(observer);
        }

        public void Notify()
        {
            foreach (var observer in this.Observers)
            {
                observer.Update();
            }
        }

        public void Remove(IObserver observer)
        {
            this.Observers.Remove(observer);
        }
    }
}
