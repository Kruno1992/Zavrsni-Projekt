using GYM4U.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GYM4U.MVC.Controllers
{
    public class MembershipTypeController : Controller
    {
        protected IMembershipTypeService Service { get; set; }

        public MembershipTypeController(IMembershipTypeService service)
        {
            Service = service;
        }
    }
}