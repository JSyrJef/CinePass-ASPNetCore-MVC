using CinePass.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace CinePass.Models
{
    public class Cinema:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Logo del cine")]
        [Required(ErrorMessage = "El logo del cine es obligatorio")]
        public string Logo { get; set; }

        [Display(Name = "Nombre del cine")]
        [Required(ErrorMessage = "El nombre del cine es obligatorio")]
        public string Name { get; set; }

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "La descripción del cine es obligatoria")]
        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
