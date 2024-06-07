using PetShelter.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShelter_Boriss.ViewModel
{
    public class RoleEditVM : BaseVM
    {
        public string Name { get; set; }

        public virtual List<User> Users { get; set; }
    }
}
