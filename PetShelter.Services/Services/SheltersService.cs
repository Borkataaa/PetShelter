using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services.Services
{
     public class SheltersService : BaseCrudService<ShelterDto , LShelterRepository>, LShelterService
    {
        public SheltersService(LShelterRepository repository) : base(repository)
        {
            
        }
    }
}
