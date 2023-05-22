using CinePass.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinePass.Models
{
    public class Actor:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Foto de perfil")]
        [Required(ErrorMessage = "La foto de perfil es obligatoria")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Nombre completo")]
        [Required(ErrorMessage = "El nombre completo es obligatorio")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre completo debe tener entre 3 y 50 caracteres")]
        public string FullName { get; set; }

        [Display(Name = "Biografía")]
        [Required(ErrorMessage = "La biografía es obligatoria")]
        public string Bio { get; set; }

        // Relaciones
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
