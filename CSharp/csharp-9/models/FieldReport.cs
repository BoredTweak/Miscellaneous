namespace csharp_9
{
    internal struct FieldReport
    {
        public DateTime Date { get; init; }
        public decimal Temperature { get; init; }
        public decimal Humidity { get; init; }

        public override string ToString() => $"Date: {Date:h::mm tt}, Temperature: {Temperature}, Humidity: {Humidity}";
    }
}