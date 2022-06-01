using System;
using System.Collections.Generic;

namespace MagicSunset.Data
{
    public class Reservations
    {
        public int Id { get; set; }
       
        public int Table { get; set; }  
        public int Guests { get; set; }  
        public int TablesId { get; set; }
        public Tables Tables { get; set; }
        public int UserId { get; set; }
        public Users User { get; set; }
        public DateTime OrderedOn { get; set; }
        
    }
}
