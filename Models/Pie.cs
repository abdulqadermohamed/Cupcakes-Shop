using System;
using System.Linq;
using System.Threading.Tasks;

namespace Cupcakes.Models
{
    public class Pie
    {
        public int pieId { get; set; }
        public string Name { get; set; }
        public string ShortDescrption { get; set; }
        public string LongDescrption { get; set; }
        public string AllInformation { get; set; }
        public decimal price { get; set; }
        public string ImgUrl { get; set; }
        public string ImgThumbUrl { get; set; }
        public bool Ispieoftheweek { get; set; }
        public bool IsStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Notes{ get; set; }
    }
}
