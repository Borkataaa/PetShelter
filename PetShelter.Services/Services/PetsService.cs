using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services.Services
{
    public class PetsService : BaseCrudService<PetDto, LPetRepository>, LPetService
    {
        public PetsService(LPetRepository repository) : base(repository)
        {
            
        }
    }
}
