﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LostAndFound.Areas.MasterData.Controllers
{
    [Area("MasterData")]
    public class AddressCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}