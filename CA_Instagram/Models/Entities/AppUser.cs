using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Instagram.Models.Entities
{
    public class AppUser
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public List<AppUserMessage> Message { get; set; }
        public List<Photo> photoList { get; set; }
        public AppUserDetail AppUserDetail { get; set; }
    }
}
