﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GYM4U.Service.Common;
using GYM4UDAL;

namespace GYM4UApp.Controllers
{
    [RoutePrefix("member")]
    public class MemberController : Controller
    {
        protected IMemberService Service { get; set; }

        public MemberController(IMemberService service)
        {
            Service = service;
        }

        private Gym4UEntities db = new Gym4UEntities();

        // GET: member/{id}
        [HttpGet]
        [Route("{id:int}")]
        public ActionResult GetMember(int id)
        {
            var member = db.Member.Find(id);
            if (member == null)
            {
                return HttpNotFound();
            }
            return View(member);
        }
    }
}
