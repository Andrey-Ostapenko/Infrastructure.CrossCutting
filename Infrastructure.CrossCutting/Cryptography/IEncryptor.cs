using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.CrossCutting.Cryptography
{
    public interface IEncryptor
    {
        string Encrypt(string data);
        string Encrypt(string data, string salt);
        bool Verify(string input, string hashedData);
        bool Verify(string input, string salt, string hashedData);
    }
}
