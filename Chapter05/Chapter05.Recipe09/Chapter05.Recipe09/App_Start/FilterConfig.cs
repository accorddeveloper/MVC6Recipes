﻿using System.Web;
using System.Web.Mvc;

namespace Chapter05.Recipe09
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
