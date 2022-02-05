using System.Collections.Generic;

namespace Cupcakes.Models
{
    public class Category
    {
        public int categoryid { get; set; }
        public string categoryName { get; set; }
        public string Descrption { get; set; }
        public List<Pie> Pies { get; set; }
    }
}
