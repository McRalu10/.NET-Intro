using System;

namespace Weather
{
    public class WeatherModel
    {
        private int dayNumber;
        private int maxTemp;
        private int minTemp;

        public WeatherModel()
        {

        }
        public WeatherModel(int day, int max, int min)
        {
            this.dayNumber = day;
            this.maxTemp = max;
            this.minTemp = min;
        }
        public int getDay()
        {
            return dayNumber;
        }
        public int getTemperatureSpread()
        {
            return maxTemp - minTemp;
        }
    }
}