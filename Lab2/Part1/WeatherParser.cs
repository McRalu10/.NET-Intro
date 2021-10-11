using System;
using System.IO;
using System.Collections.Generic;
using Weather;

namespace WeatherParser
{
    public class Parser
    {
        public List<WeatherModel> ParseWeatherData(string path)
        {
            List<WeatherModel> days = new List<WeatherModel>();
            using (var sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {

                    var split = line.Trim().Split((char[])null,StringSplitOptions.RemoveEmptyEntries);
                    try
                    {
                        days.Add(new WeatherModel(Int32.Parse(split[0]), Int32.Parse(split[1]), Int32.Parse(split[2])));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Line ignored.");
                    }
                }
            }
            return days;
        }
    }
}