﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameWebShop.Areas.Admin.Controllers
{
    [Authorize(Roles= "admin")]
    public class PostsController : Controller
    {
        public ActionResult Index()
        {
            return Content("ADMIN POSTS!");
        }
    }
}