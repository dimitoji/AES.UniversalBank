﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.UniversalBank.Portal.BusinessLogic
{
    public interface IAccountInfoManager
    {
        Models.AccountInfo GetAccountInfo(string userName);
    }
}
