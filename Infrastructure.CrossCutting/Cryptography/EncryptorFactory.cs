using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.CrossCutting.Cryptography
{
    public static class EncryptorFactory
    {
        static IEncryptorFactory _factory = null;

        public static void SetCurrent(IEncryptorFactory factory)
        {
            _factory = factory;
        }

        public static IEncryptor CreateEncryptor()
        {
            return (_factory != null) ? _factory.Create() : null;
        }
    }
}
