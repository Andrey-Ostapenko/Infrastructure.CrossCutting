using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.CrossCutting.Logging
{
    public interface ILoggerFactory
    {
        ILogger Create();
    }
}
