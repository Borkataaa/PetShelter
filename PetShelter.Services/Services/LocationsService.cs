using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services.Services
{
    public class LocationsService : BaseCrudService<LocationDto, LLocationRepository>, LocationsService
    {
        public LocationsService(ILocationRepository repository) : base(repository)
        {
            
        }
    }
}
