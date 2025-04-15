using scooters_api.System;

namespace scooter_api.Scooters.Exceptions
{
    public class ModeltypeExistException:Exception
    {
        public ModeltypeExistException():base(ExceptionMessages.ModelTypeExistException) {}
    }
}
