using System;
using System.Collections.Generic;
using Football;
using FootballParser;
using Utils;

namespace Ex2
{
    class Program
    {
        private const string PATH = ".\\football.dat";

        static void Main(string[] args)
        {
            FootballModel result = Utilities.getSmallestDifference(new Parser().ParseFootballData(PATH));
            Console.WriteLine("Team: " + result.getTeam());
        }
    }
}
