
using scooters_api.System;

namespace scooter_api.Scooters.Exceptions
{
    public class BrandExistException:Exception
    {
        public BrandExistException():base(ExceptionMessages.BrandExistException) {}
    }
}
