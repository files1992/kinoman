using System.Collections.Generic;

namespace Kinoman.Entities.MultiKino
{
    public partial class Categories
    {
        public List<CategoriesName> Names { get; set; }
        public bool Active { get; set; }
    }
}