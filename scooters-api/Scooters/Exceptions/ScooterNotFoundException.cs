using scooters_api.System;

namespace scooter_api.Scooters.Exceptions
{
    public class ScooterNotFoundException:Exception
    {
        public ScooterNotFoundException() : base(ExceptionMessages.ScooterNotFoundException) { }
    }
}
