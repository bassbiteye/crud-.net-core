using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TpGl2021Core.Models
{
    public class Etudiant
    {
        [Key]
        [ScaffoldColumn(false)]
        public int ID { get; set; }
        [Display(Name = "prénom"), MaxLength(160), Required(ErrorMessage = "*")]
        public string prenom { get; set; }
        [Display(Name = "Nom"), MaxLength(160), Required(ErrorMessage = "*")]
        public string Nom { get; set; }
        [Display(Name = "téléphone"), Required(ErrorMessage = "*")]
        public int Tel { get; set; }
        [Display(Name = "Adresse"), MaxLength(30), Required(ErrorMessage = "*")]
        public string Adresse { get; set; }
    
    }
}
