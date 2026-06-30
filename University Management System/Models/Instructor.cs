using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System.Models
{
   public class Instructor
    {

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int instructorId { get; set; } // auto-generated


        [Required]
        [MaxLength(100)]
        public string fullName { get; set; } //user input


        [Required]
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string email { get; set; } // //user input


        [MaxLength(20)]
        public string? officeNumber { get; set; } //user input


        [Required]
        public DateTime hireDate { get; set; } //user input

        [Required]
        [Range(1,int.MaxValue)]
        public decimal salary { get; set; } //user input


        [Required]
        [MaxLength(50)]
        public string academicTitle { get; set; } //user input

    }
}
