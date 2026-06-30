using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System.Models
{
    public class Enrollment
    {
        public int enrollmentId { get; set; }
        public int studentId { get; set; }
        public int courseId { get; set; }
        public DateTime enrollmentDate { get; set; }
        public string finalGrade { get; set; }
        public string status { get; set; }
    }
}
