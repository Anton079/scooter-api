namespace scooters_api.System
{
    public class ExceptionMessages
    {
        public static readonly string BrandExistException = "Scooter brand already exists.";
        public static readonly string HorsePowerExistException = "Scooter with this horsepower already exists.";
        public static readonly string IdExistException = "Scooter with this ID already exists.";
        public static readonly string IdScooterNotFound = "ID scooter nu a fost gasit!";
        public static readonly string IdTooLowException = "Scooter ID must be greater than 0.";
        public static readonly string MaxSpeedExistException = "A scooter with this max speed already exists.";
        public static readonly string ModelTypeExistException = "This scooter model type already exists.";
        public static readonly string NullBrandException = "Brand must not be null.";
        public static readonly string NullHorsePowerException = "Horse power must not be null.";
        public static readonly string NullModelTypeException = "Model type must not be null.";
        public static readonly string NullRangeException = "Range must not be null.";
        public static readonly string NullScooterException = "Scooter object is null.";
        public static readonly string NullSpeedException = "Speed must not be null.";
        public static readonly string RangeExistException = "Scooter with this range already exists.";
        public static readonly string ScooterExistException = "Scooter already exists.";
        public static readonly string ScooterNotFoundException = "Scooter not found.";
    }
}
