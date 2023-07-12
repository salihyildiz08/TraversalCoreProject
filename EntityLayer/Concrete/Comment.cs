using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int ID { get; set; }
        public string User { get; set; }
        public DateTime CommentDate { get; set; }
        public string Content { get; set; }
        public bool State { get; set; }
        public int DestinationID { get; set; }
        public Destination Destination { get; set; }
    }
}
