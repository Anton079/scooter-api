
using scooters_api.System;

namespace scooter_api.Scooters.Exceptions
{
    public class HorsePowerExistException:Exception
    {
        public HorsePowerExistException() : base(ExceptionMessages.HorsePowerExistException) { }
    }
}
