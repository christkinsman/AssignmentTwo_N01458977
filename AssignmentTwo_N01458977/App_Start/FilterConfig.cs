﻿using System.Web;
using System.Web.Mvc;

namespace AssignmentTwo_N01458977
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
