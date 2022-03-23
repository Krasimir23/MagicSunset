using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicSunset.Data
{
    public class Order
    {
        public int id { get; set; }
        public int TablesId { get; set; }
        public Tables Tab { get; set; }
        public int UserId { get; set; }
        public Users User { get; set; }
        public DateTime OrderedOn { get; set; }
    }
}
