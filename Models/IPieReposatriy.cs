using System.Collections.Generic;

namespace Cupcakes.Models
{
    public interface IPieReposatriy
    {
        IEnumerable<Pie> GetAll { get; }
        IEnumerable<Pie> PiesOfWeak { get; }
        Pie GetPieId(int id);
    }
}
