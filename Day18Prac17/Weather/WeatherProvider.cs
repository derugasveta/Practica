using System;

namespace Weather
{
    enum WeatherType
    {
        Sun,
        Rain,
        Wind,
        Snow
    }
   
    public class WeatherProvider
    {
       

        public DateOnly Data { get; init; }

        public WeatherProvider(DateOnly date)
        {
            
            Data = date;
        }

        public string GetWeather(DateOnly date)
        {

            return $"{GetWeatherType(date)} {GetTemperature(date)} ";
        }

        public int GetTemperature(DateOnly date)
        {
            var random = new Random();

            return date.Day switch
            {
                int winter when winter >= 1 || winter <= 30 => (int)random.Next(-25, 9),
                int spring when spring >= 3 || spring <= 30 => (int)random.Next(0, 13),
                int summer when summer >= 6 || summer <= 30 => (int)random.Next(4, 25),
                int autumn when autumn >= 9 || autumn <= 30 => (int)random.Next(0, 10),

            };
        }

        WeatherType GetWeatherType(DateOnly date)
        {
            var random = new Random();
            return date.Month switch
            {
                int winter when winter == 1 || winter == 2 || winter == 12 => (WeatherType)random.Next(0, 3),
                int spring when spring == 3 || spring == 4 || spring == 5 => (WeatherType)random.Next(0, 2),
                int summer when summer == 6 || summer == 7 || summer == 8 => (WeatherType)random.Next(0, 2),
                int autumn when autumn == 9 || autumn == 10 || autumn == 11 => (WeatherType)random.Next(0, 2),

            };
        }

    }
}
