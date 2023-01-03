using System;
using System.Collections.Generic;
using System.Text;

namespace Plugin.BLE.Abstractions
{
    public static class Logger
    {
        public static Action<string, string> LoggerImplementation { get; set; }

        public static void Write(string func, string message)
        {
            try
            {
                LoggerImplementation?.Invoke(func, message);
            }
            catch { /* ignore */ }
        }
    }
}
