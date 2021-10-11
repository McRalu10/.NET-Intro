using System;
using System.Collections.Generic;
using Football;

namespace Utils
{
    public static class Utilities
    {

        public static FootballModel getSmallestDifference(List<FootballModel> data)
        {
            int minimum = int.MaxValue;
            FootballModel result = new FootballModel();
            foreach (FootballModel team in data)
            {
                int average = team.getGoalAverage();
                if (average < minimum)
                {
                    minimum = average;
                    result = team;
                }
            }
            return result;
        }
    }
}