using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services.Services
{
     public class VaccinesService : BaseCrudService<VaccineDto ,  IVaccineRepository>, IVaccineService
    {
        public VaccinesService(IVaccineRepository repository) : base(repository)
        {
            
        }
    }
}
