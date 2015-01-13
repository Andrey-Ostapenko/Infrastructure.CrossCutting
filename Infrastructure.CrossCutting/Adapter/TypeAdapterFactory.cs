using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.CrossCutting.Adapter
{
    public static class TypeAdapterFactory
    {
        static ITypeAdapterFactory _currentTypeAdapterFactory = null;

        public static void SetCurrent(ITypeAdapterFactory adapterFactory)
        {
            _currentTypeAdapterFactory = adapterFactory;
        }

        public static ITypeAdapter CreateAdapter()
        {
            return (_currentTypeAdapterFactory != null) ? _currentTypeAdapterFactory.Create() : null;
        }
    }
}
