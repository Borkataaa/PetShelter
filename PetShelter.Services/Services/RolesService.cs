using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services.Services
{
    public class RolesService : BaseCrudService<RolesDto , LRoleRepository>, LRoleService
    {
        public RolesService(LRoleRepository repository) : base(repository)
        {

        }
    }
}
