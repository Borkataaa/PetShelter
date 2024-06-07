using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetShelter_Boriss.ViewModel
{
    public class LoginVM : BaseVM
    {
        [Required]
        public string Username { get;set; }

        [Required]
        public string Password { get;set; }
    }
}
