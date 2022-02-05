using Cupcakes.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cupcakes.Components
{
    public class CategoryMenu:ViewComponent
    {
        private readonly ICategoryReposatriy _categoryRepository;
        public CategoryMenu(ICategoryReposatriy categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.GetAllCategory.OrderBy(c => c.categoryName);
            return View(categories);
        }
    }
}
