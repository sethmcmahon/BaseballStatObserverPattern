using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseballStatObserverPattern
{
    interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void NotifyObservers();
    }
}
