using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseballStatObserverPattern
{
    interface IObserver
    {
        void Update(int atBats, int hits, int strikeOuts);
    }
}
