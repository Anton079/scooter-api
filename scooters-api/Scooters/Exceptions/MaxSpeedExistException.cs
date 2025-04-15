using scooters_api.System;

namespace scooter_api.Scooters.Exceptions
{
    public class MaxSpeedExistException:Exception
    {
        public MaxSpeedExistException():base(ExceptionMessages.MaxSpeedExistException) { }
    }
}
