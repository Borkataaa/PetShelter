using PetShelter.Data.Repos;
using PetShelter.Shared.Atributes;
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
    [AutoBind]
    public class LocationsService : BaseCrudService<LocationDto, ILocationRepository>, IIocationServices
    {
        public LocationsService(LocationRepository repository) : base(repository) { }
        public async Task<IEnumerable<LocationDto>> GetAllActiveAsync()
        {
            return await _repository.GetAllActiveAsync();
        }
    }
}
