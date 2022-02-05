using Cupcakes.Models;
using Cupcakes.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cupcakes.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieReposatriy _pieReposatriy;
        private readonly ICategoryReposatriy _categoryReposatriy;

        public PieController(IPieReposatriy pieReposatriy, ICategoryReposatriy categoryReposatriy)
        {
            _pieReposatriy = pieReposatriy;
            _categoryReposatriy = categoryReposatriy;
        }
     
        public IActionResult Details(int id)
        {
            var data = _pieReposatriy.GetPieId(id);
            if (data==null)
            {
                return NotFound();
            }
            return View(data);
        }

        public ViewResult List(string category)
        {
            IEnumerable<Pie> pies;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                pies = _pieReposatriy.GetAll.OrderBy(p => p.pieId);
                currentCategory = "All pies";
            }
            else
            {
                pies = _pieReposatriy.GetAll.Where(p => p.Category.categoryName == category)
                   .OrderBy(p => p.pieId);
                currentCategory = _categoryReposatriy.GetAllCategory.FirstOrDefault(c => c.categoryName == category).categoryName;
            }

            return View(new PieListViewModel
            {
                Pies = pies,
                CurrentCategory = currentCategory
            });
        }
    }
}
