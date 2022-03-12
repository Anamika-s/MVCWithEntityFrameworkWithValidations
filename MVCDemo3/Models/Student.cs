using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo3.Models
{
    public class Student
    {
        public int Id { get; set; }
        [StringLength(20, ErrorMessage = "Max characters can be 20")]
        [MinLength(10, ErrorMessage = "Min 10 characters are neede")]
        [RegularExpression("[A-Z a-z]+", ErrorMessage = "Only alphabets allowed")]


        [Required(ErrorMessage ="Name is must")]
        public string Name { get; set; }
        [Required (ErrorMessage ="Batch is must")]
        [RegularExpression("[B][0-9]{3}", ErrorMessage = "Batch Code should start from B, and should contain 3 digits")]


        public string Batch { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateofBirth { get; set; }
        [Required(ErrorMessage ="Marks are required")]
        [Range(0,100,ErrorMessage ="Range is 0 to 100")]
        public int Marks { get; set; }
        [Required(ErrorMessage ="Password is must")]

        [DataType(DataType.Password)]
        public string Password { get; set; }
        //[Required]
        [DataType(DataType.Password)]
        [ScaffoldColumn(false)]
        [Compare("Password", ErrorMessage ="Password do not match")]
        public string RetypePassword { get; set; }
    }
}
