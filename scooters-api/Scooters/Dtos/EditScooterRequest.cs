namespace scooter_api.Scooters.Dtos
{
    public class EditScooterRequest
    {
        public string Brand { get; set; }
        public string ModelType { get; set; }
        public int? HorsePower { get; set; }
        public int? Range { get; set; }
        public int? MaxSpeed { get; set; }

    }
}
