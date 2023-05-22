using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CinePass.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Nombre Completo")]
        public string FullName { get; set; }
    }
}
