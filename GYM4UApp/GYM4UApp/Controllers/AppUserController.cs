﻿using GYM4U.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GYM4U.MVC.Controllers
{
    public class AppUserController : Controller
    {
        protected IAppUserService Service { get; set; }

        public AppUserController(IAppUserService service)
        {
            Service = service;
        }
    }
}