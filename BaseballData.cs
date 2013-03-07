using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseballStatObserverPattern
{
    class BaseballData : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private int atBats;
        private int hits;
        private int strikeOuts;

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(atBats, hits, strikeOuts);
            }
        }

        public void setBaseballData(int newAtBats, int newHits, int newStrikeOuts)
        {
            atBats = newAtBats;
            hits = newHits;
            strikeOuts = newStrikeOuts;
            NotifyObservers();
        }
    }
}