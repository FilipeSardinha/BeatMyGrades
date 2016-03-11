using System.ComponentModel.DataAnnotations;
using System.Web;

namespace BeatMyGrades.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string UserName { get; set; }
    }

    public class ExternalProfLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string UserName { get; set; }
    }

    public class ManageUserViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
    public class ManageProfUserViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class LoginProfViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        public bool Prof { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string UserName { get; set; }

        //[Required]
        [Display(Name = "Apelido")]
        public string LastName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "A {0} Tem de conter pelo menos {2} caracteres de cumprimento.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirme password")]
        [Compare("Password", ErrorMessage = "A password e a confirmação da password não correspondem.")]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        [Required]
        public string Email { get; set; }

        //[Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefone")]
        public int Number { get; set; }

        //[Required]
        [Display(Name = "Escola")]
        public string School {get; set; }

        //[Required]
        [Display(Name = "NIF")]
        public int NIF { get; set; }

        //[Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Descricão")]
        public string Description { get; set; }
    }

    public class RegisterProfViewModel
    {
        [Required]
        [Display(Name = "Nome")]
        public string UserName { get; set; }

        //[Required]
        [Display(Name = "Apelido")]
        public string LastName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "A {0} Tem de conter pelo menos {2} caracteres de cumprimento.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirme password")]
        [Compare("Password", ErrorMessage = "A password e a confirmação da password não correspondem.")]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        [Required]
        public string Email { get; set; }

        //[Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefone")]
        public int Number { get; set; }

        [Display(Name = "NIF")]
        public int NIF { get; set; }

        //[Required]
        [Display(Name = "Descrição")]
        public string Description { get; set; }
    }
}
