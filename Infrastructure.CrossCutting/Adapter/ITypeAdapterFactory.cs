using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.CrossCutting.Adapter
{
    public interface ITypeAdapterFactory
    {
        ITypeAdapter Create();
    }
}
