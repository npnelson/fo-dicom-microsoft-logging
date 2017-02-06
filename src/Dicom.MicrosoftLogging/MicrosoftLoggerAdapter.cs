using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Internal;
using System;

namespace Dicom.Log
{
    internal class MicrosoftLoggerAdapter:Logger
    {
        private readonly ILogger _microsoftLogger;
        public MicrosoftLoggerAdapter(ILogger logger)
        {
            _microsoftLogger = logger;
        }

        public override void Log(LogLevel level, string msg, params object[] args)
        {      
            _microsoftLogger.Log(level.ToMicrosoftLogging(), 0, new FormattedLogValues(msg, args), null, MessageFormatter);
        }

        private static string MessageFormatter(object state, Exception error)
        {
            return state.ToString();
        }
    }
}
