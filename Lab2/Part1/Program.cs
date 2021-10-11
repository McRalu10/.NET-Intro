using System;
using System.Collections.Generic;
using Weather;
using WeatherParser;
using Utils;

namespace Ex1
{
    class Program
    {
        private const string PATH = ".\\weather.dat";

        static void Main(string[] args)
        {
            WeatherModel result = Utilities.getMinTemperatureSpreadDay(new Parser().ParseWeatherData(PATH));
            Console.WriteLine("Day: " + result.getDay());
        }
    }
}
