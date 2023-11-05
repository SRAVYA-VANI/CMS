using System.ComponentModel.DataAnnotations;

namespace CourseManagementSystemFinal.Models
{
    public class SignUpModel
    {
        //[Required]
        //public string FirstName { get; set; }
        //[Required]
        //public string LastName { get; set; }
        //[Required,EmailAddress]
        //public string Email { get; set; }
        //[Required]
        //[Compare("ConfirmPassword")]
        //public string Password { get; set; }
        //[Required]
        //public string ConfirmPassword { get; set; }



        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "username is required...!!")]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required...!!"), EmailAddress]
        [MinLength(8)]
        [MaxLength(30)]
        public string Email { get; set; }
        [Required(ErrorMessage = "password is required...!!")]
        [MinLength(8)]
        [MaxLength(16)]
        [Compare("Confirmpassword", ErrorMessage = "Password and Confirmation Password must match..")]
        public string Password { get; set; }
        [Required(ErrorMessage = "confirm password is required...!!")]
        public string Confirmpassword { get; set; }


    }
}
