using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cupcakes.Models
{
    public class CategoryRepostoriy:ICategoryReposatriy
    {
        private readonly AppDbContext _context;

        public CategoryRepostoriy(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAllCategory =>_context.Categories;
    }
}
  