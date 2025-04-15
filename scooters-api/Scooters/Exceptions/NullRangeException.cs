using scooters_api.System;

namespace scooter_api.Scooters.Exceptions
{
    public class NullRangeException:Exception
    {
        public NullRangeException() : base(ExceptionMessages.NullRangeException) { }
    }
}
