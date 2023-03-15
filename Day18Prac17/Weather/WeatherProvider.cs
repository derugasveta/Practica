namespace Weather
{
    enum WeatherType
    {
        Sun,
        Rain,
        Snow
    }
    //моожно ли присвоить им значени DateOnly
    public class WeatherProvider 
    {
        

        public void Input()
        {
            Console.WriteLine("Select a date");
            Console.WriteLine("1. 13.03.2023 \n 2. 14.03.2023 \n 3. 15.03.2023\n 4. 16.03.2023 \n 5. 17.03.2023 \n 6. 18.03.2023 \n 7. 19.03.2023");
            int data = int.Parse(Console.ReadLine());
        }
        public string GetWeather(DateOnly date)
        {

            return $"{GetWeatherType(date)}: {GetTemperature(date)} ";
        }

        private int GetTemperature(DateOnly date)
        {
            
        }

        // как засунуть метод в параметры другого 



        private WeatherType GetWeatherType(DateOnly date)
        {
            var random = new Random();
            return date.Month switch
            {
                int winter when winter == 1 || winter == 2 || winter == 12 => (WeatherType)random.Next(0, 3),
                int spring when spring == 3 || spring == 4 || spring == 5 => (WeatherType)random.Next(0, 2),
                int summer when summer == 1 || summer == 2 || summer == 12 => (WeatherType)random.Next(0, 3),
                //int ou when summer == 1 || summer == 2 || summer == 12 => (WeatherType)random.Next(0, 3),

            };
        }

    }
}
