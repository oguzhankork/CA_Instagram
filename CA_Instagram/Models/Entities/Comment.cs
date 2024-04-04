using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Instagram.Models.Entities
{
    public class Comment
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }

        public Photo PhotoId { get; set; }
    }
}
