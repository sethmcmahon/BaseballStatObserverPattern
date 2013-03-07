using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseballStatObserverPattern
{
    class OnlinePredictor : IObserver, IDisplay
    {
        private int playerAtBats;
        private int previousGameHits = 0;
        private int playerHits = 0;
        private int playerStrikeOuts;
        private BaseballData subjectBaseballData;

        public OnlinePredictor(BaseballData baseballData)
        {
            this.subjectBaseballData = baseballData;
            this.subjectBaseballData.RegisterObserver(this);
        }

        public void Update(int atBats, int hits, int strikeOuts)
        {
            playerAtBats = atBats;
            previousGameHits = playerHits;
            playerHits = hits;
            playerStrikeOuts = strikeOuts;
            Display();
        }

        public void Display()
        {
            if (previousGameHits < playerHits)
                Console.WriteLine("Online Predictor: Player getting hotter.");
            else if (previousGameHits > playerHits)
                Console.WriteLine("Online Predictor: Player getting colder.");
            else
                Console.WriteLine("Online Predictor: Player staying at same level.");
        }
    }
}