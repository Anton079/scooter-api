namespace scooter_api.Scooters.Dtos
{
    public class AddScooterRequest
    {
        public string Brand { get; set; }
        public string ModelType { get; set; }
        public int? HorsePower { get; set; }
        public int? Range { get; set; }
        public int? MaxSpeed { get; set; }
    }
}
