using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Instagram.Models.Entities
{
    public class AppUserMessage
    {
        public int ID { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }

        public AppUser UserId { get; set; }
    }
}
