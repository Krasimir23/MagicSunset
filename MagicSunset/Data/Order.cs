using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicSunset.Data
{
    public class Order
    {
        public int id { get; set; }
        public int productId { get; set; }
        public Dishess Dish { get; set; }
        public Drinks Drink { get; set; }
        public int UserId { get; set; }
        public Users User { get; set; }
        public DateTime OrderedOn { get; set; }
    }
}
