namespace CarRentalFleet
{
    public class Car
    {
        public int Id { get; set; }
        public string PlateNumber { get; set; } = string.Empty;
        public string Make { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int ProductionYear { get; set; }
        public decimal DailyRate { get; set; }
        public string Status { get; set; } = string.Empty;

        public int Age
        {
            get { return DateTime.Now.Year - ProductionYear; }
        }
    }
}
