using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services.Services
{
     public class VaccinesService : BaseCrudService<VaccineDto ,  LVacinneRepository>, LVaccineService
    {
        public VaccinesService(LVaccineRepository repository) : base(repository)
        {
            
        }
    }
}
