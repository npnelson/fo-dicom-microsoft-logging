using Dicom.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Logging
{
    public static class DICOMMicrosoftLoggingExtensions
    {
        public static ILoggerFactory InterceptDICOMLogging(this ILoggerFactory factory)
        {
            LogManager.SetImplementation(new MicrosoftLoggingManager(factory));
            return factory;
        }
    }
}
