using scooters_api.System;

namespace scooter_api.Scooters.Exceptions
{
    public class IdExistException:Exception
    {
        public IdExistException() : base(ExceptionMessages.IdExistException) { }
    }
}
