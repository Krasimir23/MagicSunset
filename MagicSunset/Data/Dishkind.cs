using System.Collections.Generic;

namespace MagicSunset.Data
{
    public class Dishkind
    {
        public int id { get; set; }
        public string appetizers { get; set; }
        public string maindish { get; set; }    
        public string dessert { get; set; }

        public  ICollection<Dishkind> Dishes { get; set; }

    }
}
