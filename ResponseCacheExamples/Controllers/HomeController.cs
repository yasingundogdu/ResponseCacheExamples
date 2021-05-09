using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ResponseCacheExamples.Models;
using ResponseCacheExamples.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ResponseCacheExamples.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFakeServices _fakeServices;

        public HomeController(ILogger<HomeController> logger, IFakeServices fakeServices)
        {
            _logger = logger;
            _fakeServices = fakeServices;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 36000, Location = ResponseCacheLocation.Any, NoStore = false)]
        public IActionResult BookList()
        {
            BookListViewModel bookListViewModel = new BookListViewModel()
            {
                BookList = _fakeServices.GetBookList()
            };

            return View(bookListViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
