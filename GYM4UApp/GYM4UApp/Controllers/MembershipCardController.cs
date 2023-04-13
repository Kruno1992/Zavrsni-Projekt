using GYM4U.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GYM4U.MVC.Controllers
{
    public class MembershipCardController : Controller
    {
        protected IMembershipCardService Service { get; set; }

        public MembershipCardController(IMembershipCardService service)
        {
            Service = service;
        }
    }
}