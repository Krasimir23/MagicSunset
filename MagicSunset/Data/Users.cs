using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace MagicSunset.Data
{
    public class Users : IdentityUser
    {
        
        public string FullName { get; set; }
        public Roles Role { get; set; }
        public ICollection<Reservations> Reser { get; set; }
       
        


    }
}
