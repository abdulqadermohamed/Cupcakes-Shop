using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cupcakes.Models
{
    public class PieReposatoriy : IPieReposatriy
    {

        private readonly AppDbContext _context;

        public PieReposatoriy(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Pie> GetAll
        {
            get
            {
                return _context.Pies.Include(a => a.Category);
            }
        }

        public IEnumerable<Pie> PiesOfWeak
        {
            get
            {
                return _context.Pies.Include(a => a.Category).Where(a => a.Ispieoftheweek);
            }
        }

        public Pie GetPieId(int id)
        {

            return _context.Pies.FirstOrDefault(a => a.pieId == id);
    

        }
    }
}
