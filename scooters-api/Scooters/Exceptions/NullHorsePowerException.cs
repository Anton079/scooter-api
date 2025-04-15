
using scooters_api.System;

namespace scooter_api.Scooters.Exceptions
{
    public class NullHorsePowerException:Exception
    {
        public NullHorsePowerException() : base(ExceptionMessages.NullHorsePowerException)
        {

        }
    }
}
