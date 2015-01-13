using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.CrossCutting.Logging
{
    public static class LoggerFactory
    {
        static ILoggerFactory _currentLogFactory = null;

        public static void SetCurrent(ILoggerFactory logFactory)
        {
            _currentLogFactory = logFactory;
        }

        public static ILogger CreateLog()
        {
            return (_currentLogFactory != null) ? _currentLogFactory.Create() : null;
        }
    }
}
