using System.Collections.Generic;

namespace Cupcakes.Models
{
    public interface ICategoryReposatriy
    {
        IEnumerable<Category> GetAllCategory { get; }

    }
}
