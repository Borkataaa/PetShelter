using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services.Services
{
     public class PetsTypeService : BaseCrudService<PetTypeDto , PetTypeRepository>, PetsTypeService
    {
        public PetsTypeService(LPetTypeRepository repository) : base(repository)
        { }
    }
}
