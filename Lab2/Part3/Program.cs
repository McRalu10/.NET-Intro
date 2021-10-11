using System;
using System.Collections.Generic;
using Models;
using Parsers;
using Utils;

namespace Ex1
{
    class Program
    {
        private const string PATH1 = ".\\weather.dat";
        private const string PATH2 = ".\\football.dat";

        static void Main(string[] args)
        {
            Model result1 = Utilities.getSmallestDifference(new Parser().ParseData(PATH1, "weather"));
            Console.WriteLine("Result 1: " + result1.getInfo());
            
            Model result2 = Utilities.getSmallestDifference(new Parser().ParseData(PATH2, "football"));
            Console.WriteLine("Result 2: " + result2.getInfo());
        }
    }
}
