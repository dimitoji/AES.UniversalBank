using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.UniversalBank.Common.Entities
{
    public static class _AccountType
    {
        public const string Savings = "Savings";
        public const string Checking = "Checking";
    }

    public static class _PayeeType
    {
        public const string A2AInternal = "A2AInternal";
        public const string A2AExternal = "A2AExternal";
        public const string EDomestic = "EDomestic";
        public const string EInternational = "EInternational";
        public const string EManual = "EManual";
    }
}
