﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TakagiSugeno.Controllers
{
    public class SystemOverviewController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(int systemId)
        {
            ViewBag.SystemId = systemId;
            return View(systemId);
        }

        public IActionResult SystemStateAlerts(int systemId)
        {
            return PartialView(systemId);
        }

        public IActionResult SystemMenu(int systemId)
        {
            return PartialView(systemId);
        }
    }
}
