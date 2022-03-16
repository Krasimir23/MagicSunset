using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicSunset.Data
{
    public class Drinks
    {
        public int id { get; set; } 
        public string drinkname { get; set; }
        public int DrinkindId { get; set; }
        public Drinkkind DrinkKind { get; set; }
        public string Description { get; set; }
        public int size { get; set; } 
        [Column(TypeName = "decimal(10,2)")]
        public decimal price { get; set; }  
       
    }
}
