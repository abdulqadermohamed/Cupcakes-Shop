using Cupcakes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cupcakes.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfWeek { get; set; }
    }
}
