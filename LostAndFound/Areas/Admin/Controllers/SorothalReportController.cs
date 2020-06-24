using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostAndFound.Areas.Admin.Models;
using LostAndFound.Areas.Lang.ReportORApplication.Models;
using LostAndFound.Areas.ReportORApplication.Models;
using LostAndFound.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace LostAndFound.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SorothalReportController : Controller
    {
        private readonly LangGenerate<SorothalLangViewModel> _lang;
        private readonly IHostingEnvironment hostingEnvironment;

        public SorothalReportController(IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
            _lang = new LangGenerate<SorothalLangViewModel>(hostingEnvironment.ContentRootPath);
        }

        public IActionResult Index()
        {
            SorothalViewModel model = new SorothalViewModel
            {
                Lang = _lang.PerseLang("Admin/SorothalReportEN.json", "Admin/SorothalReportBN.json", Request.Cookies["lang"]),
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(SorothalViewModel model)
        {
            return RedirectToAction("PageTwo");
        }

        [HttpGet]
        public IActionResult PageTwo()
        {
            SorothalViewModel model = new SorothalViewModel
            {
                Lang = _lang.PerseLang("Admin/SorothalReportEN.json", "Admin/SorothalReportBN.json", Request.Cookies["lang"]),
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult PageTwo(SorothalViewModel model)
        {
            return RedirectToAction("PageThree");
        }


        [HttpGet]
        public IActionResult PageThree()
        {
            SorothalViewModel model = new SorothalViewModel
            {
                Lang = _lang.PerseLang("Admin/SorothalReportEN.json", "Admin/SorothalReportBN.json", Request.Cookies["lang"]),
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult PageThree(SorothalViewModel model)
        {
            return View();
        }

    }
}