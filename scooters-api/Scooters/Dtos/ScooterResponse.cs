namespace scooter_api.Scooters.Dtos
{
    public class ScooterResponse
    {
        public int Id {  get; set; }
        public string Brand { get; set; }
        public string ModelType { get; set; }
        public int? HorsePower { get; set; }
        public int? Range { get; set; }
        public int? MaxSpeed { get; set; }


    }
}
