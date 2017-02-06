using Microsoft.Extensions.Logging;

namespace Dicom.Log
{
    internal class MicrosoftLoggingManager : LogManager
    {
        private readonly ILoggerFactory _microsoftLoggerFactory;

        public MicrosoftLoggingManager(ILoggerFactory microsoftLoggerFactory)
        {
            _microsoftLoggerFactory = microsoftLoggerFactory;
        }
        protected override Logger GetLoggerImpl(string name)
        {
            return new MicrosoftLoggerAdapter(_microsoftLoggerFactory.CreateLogger(name));
        }
    }
}
