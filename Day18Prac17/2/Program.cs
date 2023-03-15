using Weather;
Console.Write("Select a date: ");
DateOnly date = DateOnly.Parse(Console.ReadLine());
WeatherProvider weather = new WeatherProvider(date);
Console.WriteLine();
Console.WriteLine( $"Weather on {date} - {weather.GetWeather(date)}") ;

