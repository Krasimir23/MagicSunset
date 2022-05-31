using System.ComponentModel.DataAnnotations;

namespace MagicSunset.Models
{
    public class TablesVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required")]
        
        public decimal Count { get; set; }

        [Required(ErrorMessage = "This field is required")]

        public string Descr{ get; set; }

        [Required(ErrorMessage = "This field is required")]
        public DataTime Date { get; set; }
    }
}
