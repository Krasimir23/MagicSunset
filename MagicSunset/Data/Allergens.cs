using System.Collections.Generic;

namespace MagicSunset.Data
{
    public class Allergens
    {
        public int id { get; set; }
        public string milk { get; set; }
        public string egg { get; set; } 
        public string fish { get; set; }    
        public string peanut { get; set; }
        public string wheat { get; set; }

        public  ICollection<Allergens> allergens { get; set; }

    }
}
