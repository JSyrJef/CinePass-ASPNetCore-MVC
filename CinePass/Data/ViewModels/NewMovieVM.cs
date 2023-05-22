using CinePass.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;

namespace CinePass.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Display(Name = "Nombre de la película")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Name { get; set; }

        [Display(Name = "Descripción de la película")]
        [Required(ErrorMessage = "La descripción es obligatoria")]
        public string Description { get; set; }

        [Display(Name = "Precio en $")]
        [Required(ErrorMessage = "El precio es obligatorio")]
        public double Price { get; set; }

        [Display(Name = "URL del póster de la película")]
        [Required(ErrorMessage = "La URL del póster de la película es obligatoria")]
        public string ImageURL { get; set; }

        [Display(Name = "Fecha de inicio de la película")]
        [Required(ErrorMessage = "La fecha de inicio es obligatoria")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Fecha de finalización de la película")]
        [Required(ErrorMessage = "La fecha de finalización es obligatoria")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Selecciona una categoría")]
        [Required(ErrorMessage = "La categoría de la película es obligatoria")]
        public MovieCategory MovieCategory { get; set; }

        // Relaciones
        [Display(Name = "Selecciona actor(es)")]
        [Required(ErrorMessage = "El(los) actor(es) de la película son obligatorios")]
        public List<int> ActorIds { get; set; }

        [Display(Name = "Selecciona un cine")]
        [Required(ErrorMessage = "El cine de la película es obligatorio")]
        public int CinemaId { get; set; }

        [Display(Name = "Selecciona un productor")]
        [Required(ErrorMessage = "El productor de la película es obligatorio")]
        public int ProducerId { get; set; }
    }
}
