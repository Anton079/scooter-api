using scooters_api.System;

namespace scooter_api.Scooters.Exceptions
{
    public class IdToLowException:Exception
    {
        public IdToLowException() : base(ExceptionMessages.IdTooLowException) { }

    }
}
