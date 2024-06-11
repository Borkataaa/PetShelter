using PetShelter.Data.Entities;
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
    public class PetsVaccineService : BaseCrudService<PetVaccineDto, IPetVaccineRepository>, IPetVaccineService
    {
        public PetsVaccineService(IPetVaccineRepository repository) : base(repository)
        { }

        public Task SaveAsync(PetVaccineDto model)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<PetVaccineDto>> IBaseCrudService<PetVaccineDto, IPetVaccineRepository>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<PetVaccineDto> IBaseCrudService<PetVaccineDto, IPetVaccineRepository>.GetByIdIfExistsAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<PetVaccineDto>> IBaseCrudService<PetVaccineDto, IPetVaccineRepository>.GetWithPaginationAsync(int pageSize, int pageNumber)
        {
            throw new NotImplementedException();
        }
    }
}
