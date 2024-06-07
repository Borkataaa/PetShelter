using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services.Services
{
    public class BreedsService : BaseCrudService<BreedDto, IBaseRepository>, IBreedsService
    {
        public BreedsService(IBreedRepository repository) : base(repository)
            { }
    }
    
}
