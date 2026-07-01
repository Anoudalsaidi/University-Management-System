using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_System.Models
{
   public class Review
    {
        public int reviewId { get; set; }
        public int userId { get; set; }
        public int productId { get; set; }
        public int rating { get; set; }
        public string comment { get; set; }
        public DateTime reviewDate { get; set; }
    }
}
