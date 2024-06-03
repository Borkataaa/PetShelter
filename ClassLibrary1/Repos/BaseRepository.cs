using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PetShelter.Data.Entities;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PetShelter.Shared.Repos
{

    public abstract class BaseRepository<T, TModel> : IBaseRepository<TModel>, IDisposable
        where T : BaseEntity
        where TModel : BaseModel
    {

        protected readonly DbContext _context;
        protected readonly DbSet<T> _dbSet;
        protected readonly IMapper mapper;
        private bool disposedValue;

        protected BaseRepository(PetShelterDbContext context, IMapper mapper)
        {
            _context = context;
            _dbSet = _context.Set<T>();
            this.mapper = mapper;
        }

        public virtual TModel MapToModel(T entity)
        {
            return mapper.Map<T>(entity);
        }

        public virtual T MapToEntity(TModel model)
        {
            return mapper.Map<T>(model);
        }

        public virtual IEnumerable<TModel> MapToEnumerableOfModel(IEnumerable<T> entities)
        {
            return mapper.Map<IEnumerable<TModel>>(entities);
        }

        public async Task<TModel> GetByIdAsync(int id)
        {
            var user = await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            return this.MapToModel(user);
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await this._dbSet.FindAsync(id);

            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            try
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
            }
            catch (SqlException ex)
            {
                await Console.Out.WriteLineAsync($"The system threw an  sql exeption trying to delete {nameof(entity)}: {ex.Messege}");
            }
            catch (Exception ex)
            {
                await Console.Out.WriteLineAsync($"The sysytem threw a non-sql exption trying to delete {nameof(entity)} : {ex.Message} ");
            }
        }

        public Task<bool> ExistsByIdAsync(int id)
        {
            return _dbSet.AnyAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<TModel>> GetWithPaginationAsync(int pageSize, int pageNumber)
        {
            var paginatedRecords = await _dbSet
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

                return MapToEnumerableOfModel(paginatedRecords);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
