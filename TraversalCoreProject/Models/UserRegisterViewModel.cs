using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProject.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Please Enter Your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Your SurName")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Please Enter Your UserName")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Please Enter Your Mail")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Please Enter Your Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter Your ConfirmPassword")]
        [Compare("Password",ErrorMessage = "passwords are not compatible")]
        public string ConfirmPassword { get; set; }
    }
}
