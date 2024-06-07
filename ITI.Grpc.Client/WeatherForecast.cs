namespace lab.Grpc.Client
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TempC { get; set; }

        public int TempF => 32 + (int)(TempC / 0.5556);

        public string? Winter { get; set; }
    }
}
