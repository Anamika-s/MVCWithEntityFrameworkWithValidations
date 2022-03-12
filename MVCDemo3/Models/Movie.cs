using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo3.Models
{ 
    //[Table("tbl_Movie")]
    public class Movie
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Genre is required")]
        [StringLength(10, ErrorMessage = "Maximum 10 characters can be added")]
        [MinLength(6, ErrorMessage = "Min 6 characaters needed")]
        
        public string Genre { get; set; }


        [Required(ErrorMessage = "Name is must")]
        [RegularExpression("[A-Z a-z]+", ErrorMessage = "Only alphabets allowed")]
        [Display(Name="Movie Name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Director Name is must")]
        [RegularExpression("[A-Z a-z]+", ErrorMessage = "Only alphabets allowed")]
        [Display(Name="Director Name")]
        public string Director { get; set; }


        [Display(Name="Release Year")]
        [Required(ErrorMessage = "Release Year is Required")]
        [Range(10, 20, ErrorMessage = "Range should be in 10 - 20")]
        public int ReleaseYear { get; set; }

        [Required(ErrorMessage = "Password is must")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Passsord is must")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ReTypePassword { get; set; }

        [Required(ErrorMessage ="Release Date is must")]

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [ReleaseDateAttribute]
        [DataType(DataType.Date)]
         public DateTime DateofRelease { get; set; }
        [RatingAttribute]
        public int Rating { get; set; }
    }

}
