﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.UniversalBank.Common.Entities
{
    public class Account
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public decimal? BalanceValue { get; set; }
        public DateTime? BalanceDate { get; set; }
    }
}
