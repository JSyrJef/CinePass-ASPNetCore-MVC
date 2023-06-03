using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CinePass.Data.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "Nombre completo")]
        [Required(ErrorMessage = "El nombre completo es obligatorio")]
        public string FullName { get; set; }

        [Display(Name = "Dirección de correo electrónico")]
        [Required(ErrorMessage = "La dirección de correo electrónico es obligatoria")]
        public string EmailAddress { get; set; }

        //[Required(ErrorMessage = "La contraseña es obligatoria")]
        //[DataType(DataType.Password)]
        //public string Password { get; set; }

        //[Display(Name = "Confirmar contraseña")]
        //[Required(ErrorMessage = "La confirmación de contraseña es obligatoria")]
        //[DataType(DataType.Password)]
        //[Compare("Password", ErrorMessage = "Las contraseñas no coinciden")]
        //public string ConfirmPassword { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "La contraseña debe tener al menos 8 caracteres.")]
        [RegularExpression(@"^(?=.*[0-9])(?=.*[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]+$",
        ErrorMessage = "La contraseña debe contener al menos un número y un signo especial.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Las contraseñas no coinciden.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
