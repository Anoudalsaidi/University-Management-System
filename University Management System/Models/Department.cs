using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System.Models
{
    public class Department
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int departmentId { get; set; } // auto-generated


        [Required]
        [MaxLength(100)]
        public string departmentName { get; set; } // user input


        [MaxLength(50)]
        public string? building { get; set; } //user input


        [Required]
        [Range(0,int.MaxValue)]
        public decimal budget { get; set; } //user input


        [ForeignKey("Instructor")]
        public int? headInstructorId { get; set; } //auto-generated


        //RELATIONSHIPS WITH Course(one-many)
        public List<Course> courses { get; set; } // Navigation Property


        //RELATIONSHIPS WITH Instructor(one-one)
        public Instructor Instructor { get; set; } // Navigation Property


    }
}
