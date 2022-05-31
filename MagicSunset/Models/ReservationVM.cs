using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MagicSunset.Models
{
    public class ReservationVM
    {
        public int Id { get; set; }

        public int TablesId { get; set; }

        public List<SelectListItem> Tables { get; set; }

        public string UserId { get; set; }

       

        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.Date)]
        [Display(Name = "Date of reservation: ")]
        public DateTime OrderedOn { get; set; }
    }
}

