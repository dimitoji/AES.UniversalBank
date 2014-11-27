using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.UniversalBank.External.Directory
{
    public interface IDirectoryService
    {
        Common.Entities.Customer AuthenticateCustomer(string login, string password);
    }
}
