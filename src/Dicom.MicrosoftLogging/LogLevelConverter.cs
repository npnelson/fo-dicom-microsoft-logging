
namespace Dicom.Log
{
    internal static class LogLevelConverter
    {
        public static Microsoft.Extensions.Logging.LogLevel ToMicrosoftLogging(this LogLevel dicomLogLevel)
        {
            switch (dicomLogLevel)
            {
                case LogLevel.Debug:
                    return Microsoft.Extensions.Logging.LogLevel.Debug;
                case LogLevel.Error:
                    return Microsoft.Extensions.Logging.LogLevel.Error;
                case LogLevel.Fatal:
                    return Microsoft.Extensions.Logging.LogLevel.Critical;
                case LogLevel.Info:
                    return Microsoft.Extensions.Logging.LogLevel.Information;
                case LogLevel.Warning:
                    return Microsoft.Extensions.Logging.LogLevel.Warning;
                default:
                    //pathological case - shouldn't occur
                    return Microsoft.Extensions.Logging.LogLevel.Trace;  
            }
        }
    }
}
