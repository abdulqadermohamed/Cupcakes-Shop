using Cupcakes.Models;
using Cupcakes.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cupcakes.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieReposatriy _pieReposatoriy;

        public HomeController(IPieReposatriy pieReposatoriy)
        {
            _pieReposatoriy = pieReposatoriy;
        }
        public IActionResult Index()
        {
            var homeviewModel = new HomeViewModel()
            {
                PiesOfWeek = _pieReposatoriy.PiesOfWeak
            };
          
            return View(homeviewModel);
        }
    }
}
