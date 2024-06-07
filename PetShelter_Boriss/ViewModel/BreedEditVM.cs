using PetShelter.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetShelter_Boriss.ViewModel
{
    public class BreedEditVM:BaseVM
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public BreedSize Size { get; set; }
    }
}
