﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.CrossCutting.Logging
{
    public interface ILogger
    {
        void Debug(string message, params object[] args);
        void Debug(string message, Exception exception, params object[] args);
        void Debug(object item);
        
        void Fatal(string message, params object[] args);
        void Fatal(string message, Exception exception, params object[] args);

        void LogInfo(string message, params object[] args);

        void LogWarning(string message, params object[] args);

        void LogError(string message, params object[] args);
        void LogError(string message, Exception exception, params object[] args);
    }
}
