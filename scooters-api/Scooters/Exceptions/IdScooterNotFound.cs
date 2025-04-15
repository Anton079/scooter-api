using scooters_api.System;

namespace scooter_api.Scooters.Exceptions
{
    public class IdScooterNotFound:Exception
    {
        public IdScooterNotFound() :base(ExceptionMessages.IdScooterNotFound) {}
    }
}
