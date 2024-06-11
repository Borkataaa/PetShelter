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
     public class UsersService : BaseCrudService<UserDto , IUserRepository>, IUserService
    {
        public UsersService(IUserRepository repository) : base(repository)
        {
            
        }

        public Task<bool> CanUserLoginAsync(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> GetByUsernameAsync(string username)
        {
            throw new NotImplementedException();
        }
    }
}
