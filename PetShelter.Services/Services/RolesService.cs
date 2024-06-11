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
    public class RolesService : BaseCrudService<RoleDto , IRoleRepository>, IRoleService
    {
        public RolesService(IRoleRepository repository) : base(repository)
        {

        }

        public Task<RoleDto> GetByNameIfExistsAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}
