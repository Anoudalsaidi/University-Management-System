using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System.Models
{
  public class Student
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int studentId { get; set; } // auto-generated


        [Required]
        [MaxLength(100)]
        public string fullName { get; set; } //user input


        [Required]
        [RegularExpression(@"^[a-zA-Z]+$")]
        [MaxLength(150)]
        public string email { get; set; } //user input



        [MaxLength(20)]
        public string? phoneNumber { get; set; } //user input


        [Required]
        public DateTime dateOfBirth { get; set; } //user input


        [Required]
        [Range(2000,2003)]
        public int enrollmentYear { get; set; } //user input



        [Range(0.0,4.0)]
        public decimal gpa { get; set; } = 0.0m; //calculated


        //RELATIONSHIPS WITH Enrollment(one-many)
        public List<Enrollment> enrollments { get; set; } // Navigation Property
    }
}
