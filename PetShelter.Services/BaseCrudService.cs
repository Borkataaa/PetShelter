using PetShelter.Data.Repos;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services
{
    public abstract class BaseCrudService<TModel, TRepository> : IBaseCrudService<TModel, TRepository>

        where TModel : BaseModel
        where TRepository : IBaseRepository<TModel>
    {
        protected readonly TRepository _repository;


        protected BaseCrudService(TRepository repository)
        {
            this._repository = repository;
        }

        public virtual async Task SaveAsync(TModel model)
        {
            if (Equals(model, null))
            {
                throw new ArgumentNullException(nameof(model));
            }
            await this._repository.SaveAsync(model);
        }

        public virtual Task DeleteAsync(int id)
            => this._repository.DeleteAsync(id);

        public virtual Task<TModel> GetByIdIfExistsAsync(int id)
            => this._repository.GetByIdAsync(id);

        public virtual Task<IEnumerable<TModel>> GetWithPaginationAsync(int pageSize, int pageNumber)
            => this._repository.GetWithPaginatioinAsync(pageSize, pageNumber);

        public virtual Task<IEnumerable<TModel>> GetAllAsync()
            => this._repository.GetAllAsync();

        public Task<bool> ExistsBeIdAsync(int id)
            => this._repository.ExistsByIdAsync(id);

        public abstract Task CreateAsync(TModel model);
        public abstract Task<IEnumerable<TModel>> GetWithPaginatioinAsync(int pageSize, int pageNumber);
        public abstract Task<bool> ExistsByIdAsync(int id);

    }
       
}
