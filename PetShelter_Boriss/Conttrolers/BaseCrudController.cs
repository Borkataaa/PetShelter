using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PetShelter.Shared;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter_Boriss.ViewModel;

namespace PetShelter_Boriss.Conttrolers
{
    public abstract class BaseCrudController<TModel, TRepository ,TService , TEditVM ,TDetailsVM> : Controller
        where TModel : BaseModel
        where TRepository : IBaseRepository<TModel>
        where TService : IBaseCrudService<TModel , TRepository>
        where TEditVM : BaseVM, new()
        where TDetailsVM : BaseVM
    {
        protected readonly TService _service;
        protected readonly IMapper _mapper;

        protected BaseCrudController(TService service ,IMapper mapper)
        {
            this._service = service;
            _mapper = mapper;
        }

        protected const int DefaultPageSize = 10;
        protected const int DefaultPageNumber = 1;
        protected const int MaxPageSize = 100;

        protected virtual Task<string?> Validate(TEditVM editVM)
        {
            return Task.FromResult<string?>(null);
        }

        protected virtual Task<TEditVM> PrePopulateVMAsync(TEditVM editVM)
        {
            return Task.FromResult(editVM);
        }

        [HttpGet]
        public virtual async Task<IActionResult> List(
            int pageSize = DefaultPageSize,
            int pageNumber = DefaultPageNumber)
        {
            if (pageSize <= 0 ||
                pageSize > MaxPageSize ||
                pageNumber <= 0)
            {
                return BadRequest(Constants.InvalidPagination);
            }

            var models = await this._service.GetWithPaginatioinAsync(pageSize, pageNumber);
            var mappedModels = _mapper.Map<IEnumerable<TDetailsVM>>(models);
            return View(nameof(List), mappedModels);
        }

        [HttpGet]
        public virtual async Task<IActionResult> Details(int id)
        {
            var model = await this._service.GetByIdIfExistsAsync(id);
            if (model == default)
            {
                return BadRequest(Constants.InvalidId);
            }
            var mappedModel = _mapper
        }
            
            
    }
}
