using scooters_api.System;

namespace scooter_api.Scooters.Exceptions
{
    public class NullBrandException : Exception
    {
        public NullBrandException() :base(ExceptionMessages.NullBrandException)
        {

        }
    }
}
