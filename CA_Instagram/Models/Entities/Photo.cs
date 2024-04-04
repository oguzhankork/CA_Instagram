using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Instagram.Models.Entities
{
    public class Photo
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }


        public int UserId { get; set; }
        public List<Comment> commentList { get; set; }
    }
}
