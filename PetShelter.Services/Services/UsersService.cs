using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services.Services
{
     public class UsersService : BaseCrudService<UserDto , LUserRepository>, LuserService
    {
        public UsersService(LUserRepository repository) : base(repository)
        {
            
        }
    }
}
