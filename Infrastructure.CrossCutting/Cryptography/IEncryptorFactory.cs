using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.CrossCutting.Cryptography
{
    public interface IEncryptorFactory
    {
        IEncryptor Create();
    }
}
