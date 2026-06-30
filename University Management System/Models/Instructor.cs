using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System.Models
{
   public class Instructor
    {
        public int instructorId { get; set; }
        public string fullName { get; set; }
        public string email { get; set; }
        public string officeNumber { get; set; }
        public DateTime hireDate { get; set; }
        public decimal salary { get; set; }
        public string academicTitle { get; set; }

    }
}
