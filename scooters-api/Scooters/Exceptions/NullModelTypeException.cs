using scooters_api.System;

namespace scooter_api.Scooters.Exceptions
{
    public class NullModelTypeException:Exception
    {
        public NullModelTypeException() :base(ExceptionMessages.NullModelTypeException) { }
    }
}
