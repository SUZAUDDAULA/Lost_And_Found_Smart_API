using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostAndFound.Areas.LostFound.Models;
using LostAndFound.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace LostAndFound.Areas.LostFound.Controllers
{
    [Area("LostFound")]
    [Authorize]
    public class SearchController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly LangGenerate<SearchLn> _lang;

        public SearchController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            _lang = new LangGenerate<SearchLn>(_hostingEnvironment.ContentRootPath);
        }

        public IActionResult Index()
        {
            SearchViewModel model = new SearchViewModel
            {
                searchLn= _lang.PerseLang("LostFound/SearchEN.json", "LostFound/SearchBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        public IActionResult SearchByImage()
        {
            SearchViewModel model = new SearchViewModel
            {
                searchLn = _lang.PerseLang("LostFound/SearchEN.json", "LostFound/SearchBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        
    }
}