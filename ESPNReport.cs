using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseballStatObserverPattern
{
    class ESPNReport : IObserver, IDisplay
    {
        private int playerAtBats;
        private int playerHits;
        private int playerStrikeOuts;
        private BaseballData subjectBaseballData;

        public ESPNReport(BaseballData baseballData)
        {
            this.subjectBaseballData = baseballData;
            this.subjectBaseballData.RegisterObserver(this);
        }

        public void Update(int atBats, int hits, int strikeOuts)
        {
            playerAtBats = atBats;
            playerHits = hits;
            playerStrikeOuts = strikeOuts;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("ESPN Player Report: " + playerHits.ToString() + " for " + playerAtBats.ToString() + " with " + playerStrikeOuts.ToString() + " Strikeouts.");
        }
    }
}
