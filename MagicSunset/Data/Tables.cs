using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicSunset.Data
{
    public class Tables
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public string Descr { get; set; }
        public ICollection<Reservations> Reser { get; set; }
    }
}
