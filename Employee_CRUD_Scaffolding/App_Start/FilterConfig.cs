﻿using System.Web;
using System.Web.Mvc;

namespace Employee_CRUD_Scaffolding
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
