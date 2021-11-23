using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ThucHanhTuan5.Models;

namespace ThucHanhTuan5.Controllers
{
    public class HomeController : Controller
    {
        private readonly Storectx _context;

        public HomeController(Storectx context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Cau3()
        {
        
            return View(_context.Cau3());
        }
        public IActionResult Cau4()
        {

            return View(_context.Cau4());
        }
        public IActionResult Cau5()
        {

            return View(_context.Cau5());
        }
        public IActionResult Cau6()
        {

            return View(_context.Cau6());
        }
        public IActionResult Cau7()
        {

            return View(_context.Cau7());
        }
        public IActionResult Cau8()
        {

            return View(_context.Cau8());
        }
        virtual public IActionResult Cau9()
        {

            return View(_context.Cau9());
        }
        virtual public IActionResult Cau13()
        {

            return View(_context.Cau13());
        }
        virtual public IActionResult Cau14()
        {

            return View(_context.Cau14());
        }
        virtual public IActionResult Cau17()
        {

            return View(_context.Cau17());
        }

    }
}
