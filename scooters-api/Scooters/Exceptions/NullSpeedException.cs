using scooters_api.System;

namespace scooter_api.Scooters.Exceptions
{
    public class NullSpeedException:Exception
    {
        public NullSpeedException() :base(ExceptionMessages.NullSpeedException) { }
    }
}
