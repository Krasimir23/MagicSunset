using Microsoft.AspNetCore.Identity;

namespace MagicSunset.Data
{
    public class Users : IdentityUser
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public int number { get; set; }
        public int date { get; set; }


    }
}
