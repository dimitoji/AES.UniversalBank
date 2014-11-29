using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.UniversalBank.Portal.Authentication
{
    public interface IDirectoryManager
    {
        bool Login(string login, string password);
    }
}
