using Cupcakes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cupcakes.ViewModels
{
    public class PieListViewModel
    {
        public IEnumerable<Pie>  Pies{ get; set; }
        public string CurrentCategory { get; set; }
    }
}
