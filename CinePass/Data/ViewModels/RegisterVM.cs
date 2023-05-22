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

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirmar contraseña")]
        [Required(ErrorMessage = "La confirmación de contraseña es obligatoria")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Las contraseñas no coinciden")]
        public string ConfirmPassword { get; set; }
    }
}
