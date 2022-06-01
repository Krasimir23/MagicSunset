using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicSunset.Data
{
    public class Drinks
    {
        public int Id { get; set; } 
        public string Drinkname { get; set; }
        
        public Drinkkind DrinkKind { get; set; }
        public string Description { get; set; }
        public int Size { get; set; } 
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }  
       
    }
}
