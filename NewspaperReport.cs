using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseballStatObserverPattern
{
    class NewspaperReport : IObserver, IDisplay
    {
        private int playerAtBats;
        private int playerHits;
        private int playerStrikeOuts;
        private BaseballData subjectBaseballData;

        public NewspaperReport(BaseballData baseballData)
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
            Console.WriteLine("Newspaper Report: Player got " + playerHits.ToString() + " hits!");
        }
    }
}