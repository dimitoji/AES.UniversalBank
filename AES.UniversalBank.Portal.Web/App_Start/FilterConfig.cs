﻿using System.Web;
using System.Web.Mvc;

namespace AES.UniversalBank.Portal.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
