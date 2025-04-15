using scooters_api.System;

namespace scooter_api.Scooters.Exceptions
{
    public class RangeExistException:Exception
    {
        public RangeExistException() :base(ExceptionMessages.RangeExistException) { }
    }
}
