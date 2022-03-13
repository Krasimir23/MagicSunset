using System.Collections.Generic;

namespace MagicSunset.Data
{
    public class Drinkkind
    {
        public int id  { get; set; }
        public string alchohol { get; set; }
        public string nonalchohol { get; set; }   
        public string carbonated  { get; set; }
        public string juice { get; set; }

        public  ICollection<Drinkkind> dkind { get; set; }
    }
}
