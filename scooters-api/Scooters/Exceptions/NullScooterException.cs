using scooters_api.System;

namespace scooter_api.Scooters.Exceptions
{
    public class NullScooterException : Exception
    {
        public NullScooterException() : base(ExceptionMessages.NullScooterException)
        {

        }
    }
}
