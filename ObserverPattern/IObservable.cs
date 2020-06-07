using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface IObservable
    {
        // To register an observer
        void Add(IObserver observer);

        // To remove an observer
        void Remove(IObserver observer);

        // To broadcast the change to the observers
        void Notify();
    }
}
