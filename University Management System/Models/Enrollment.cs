using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System.Models
{
    //status value
    public enum EnrollmentStatus
    {
        InProgress
    }

    public class Enrollment
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int enrollmentId { get; set; } //auto-generated


        [ForeignKey("Student")]
        [Required]
        public int studentId { get; set; } //Foreign Key
       
        
        [ForeignKey("Course")]
        [Required]
        public int courseId { get; set; }  //Foreign Key
        
        [Required]
        public DateTime enrollmentDate { get; set; } //user input
        
        [MaxLength(2)]
        public string? finalGrade { get; set; } //caculated
        
        
        [Required]
        [MaxLength(20)]
        public EnrollmentStatus status { get; set; } // default  value


        //RELATIONSHIPS WITH Student(many-one)
        public Student student { get; set; } //Navigation Property

        //RELATIONSHIPS WITH Course((many-one)
        public Course course { get; set; } // Navigation Property
    }
}
