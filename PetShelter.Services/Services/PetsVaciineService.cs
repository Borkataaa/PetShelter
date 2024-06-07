using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services.Services
{
    public class PetsVaccineService : BaseCrudService<PetsVaccineService, PetVaccineRepository>, PetsVaccineService
    {
        public PetsVaccineService(LPetVaccineRepositorty repository) : base(repository)
        { }
    }
}
