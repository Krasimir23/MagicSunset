using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicSunset.Data
{
    public class Dishess
    {
        public int Id { get; set; } 
        public string Dishname { get; set; }
        public string Dishkind { get; set; }
        public Dishkind Dishekind { get; set; }
       
        public int Gram { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal  Price { get; set; }  
       
        
        
        
         
    }
}
