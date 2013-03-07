using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseballStatObserverPattern
{
    class BaseballStats
    {
        static void Main(string[] args)
        {
            // Subject (notifier)
            BaseballData baseballData = new BaseballData();

            // Observers
            ESPNReport espn = new ESPNReport(baseballData);
            NewspaperReport paper = new NewspaperReport(baseballData);
            OnlinePredictor online = new OnlinePredictor(baseballData);

            baseballData.setBaseballData(4, 3, 1);
            baseballData.setBaseballData(4, 0, 3);
            baseballData.setBaseballData(4, 0, 2);
            baseballData.setBaseballData(4, 4, 3);
            baseballData.setBaseballData(3, 2, 1);
            baseballData.setBaseballData(5, 2, 2);
            baseballData.setBaseballData(3, 2, 0);
        }
    }
}