using GYM4U.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GYM4U.MVC.Controllers
{
    public class ActivityController : Controller
    {
        protected IActivityService Service { get; set; }

        public ActivityController(IActivityService service)
        {
            Service = service;
        }
    }
}