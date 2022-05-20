using System.ComponentModel.DataAnnotations;
namespace Identity_Login_and_Registration_ASPCore_.ViewModels
{
    public class Register
    {   
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage ="Don't match with password!")]
        public string ConfirmPassword { get; set; }

    }
}
