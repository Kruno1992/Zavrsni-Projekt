using GYM4U.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GYM4U.MVC.Controllers
{
    public class RoleController : Controller
    {
        protected IRoleService Service { get; set; }

        public RoleController(IRoleService service)
        {
            Service = service;
        }
    }
}