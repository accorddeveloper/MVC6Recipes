﻿using System.Web;
using System.Web.Mvc;

namespace Recipe03.LegacyWebApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}