using System;

namespace Football
{
    public class FootballModel
    {
        private string team;
        private int forGoals;
        private int againstGoals;

        public FootballModel()
        {

        }
        public FootballModel(string name, int forGoals, int againstGoals)
        {
            this.team = name;
            this.forGoals = forGoals;
            this.againstGoals = againstGoals;
        }
        public string getTeam()
        {
            return team;
        }

        //always positive
        public int getGoalAverage()
        {
            if (forGoals < againstGoals)
                return againstGoals - forGoals;
            return forGoals - againstGoals;
        }
    }
}