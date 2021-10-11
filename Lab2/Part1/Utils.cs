using System;
using System.Collections.Generic;
using Weather;

namespace Utils
{
    public static class Utilities
    {

        public static WeatherModel getMinTemperatureSpreadDay(List<WeatherModel> data)
        {
            int minimum = int.MaxValue;
            WeatherModel result = new WeatherModel();
            foreach (WeatherModel day in data)
            {
                int spread = day.getTemperatureSpread();
                if (spread < minimum)
                {
                    minimum = spread;
                    result = day;
                }
            }
            return result;
        }
    }
}