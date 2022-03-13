using System.Collections.Generic;

namespace MagicSunset.Data
{
    public class Reservations
    {
        public int id { get; set; }
        public int date { get; set; }
        public int hour { get; set; }   
        public int table { get; set; }  
        public int guests { get; set; }  

        public ICollection<Reservations> Res { get; set; }
    }
}
