using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicSunset.Data
{
    public class Dishess
    {
        public int id { get; set; } 
        public string dishname { get; set; }
        public string dishkind { get; set; }
        public string allergens { get; set; }   
        public int gram { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal  price { get; set; }  
        public Food foodkind { get; set; }
        
        public ICollection<Order> Orders { get; set; }  
    }
}
