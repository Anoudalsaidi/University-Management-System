using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System.Models
{
   public class Course
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int courseId { get; set; } // auto-generated

        [Required]
        [MaxLength(10)]
        public string courseCode { get; set; } // user input & unique

        [Required]
        [MaxLength(150)]
        public string courseTitle { get; set; } // user input

        [Required]
        [Range(1,6)]
        public int creditHours { get; set; } // user input

        [ForeignKey("Department")]
        [Required]
        public int departmentId { get; set; } //Foreign Key

        [ForeignKey("Instructor")]
        public int? instructorId { get; set; }  //Foreign Key


        [Required]
        [MaxLength(20)]
        public string semesterOffered { get; set; } //user input


        //RELATIONSHIPS WITH Enrollment(one-many)
        public List<Enrollment> enrollments { get; set; } // Navigation Property

        //RELATIONSHIPS WITH Department(many-one)
        public Department department { get; set; } // Navigation Property


        //RELATIONSHIPS WITH Instructor(many-one)
        public Instructor Instructor { get; set; } // Navigation Property


    }
}
