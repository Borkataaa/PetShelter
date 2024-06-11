using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Services.Contracts;
using PetShelter_Boriss.ViewModel;

namespace PetShelter_Boriss.Conttrolers
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Admin, Employee")]
    public class ShelterController : BaseCrudController<ShelterDto, IShelterRepository, IShelterService, ShelterEditVM, ShelterDetailsVM>
    {
        protected readonly IIocationServices _locationService;
        public ShelterController(IShelterService service, IMapper mapper) : base(service, mapper)
        {

        }
        protected override async Task<ShelterEditVM> PrePopulateVMAsync(ShelterEditVM editVM)
        {

            editVM.LocationList = (await _locationService.GetAllActiveAsync())
                .Select(x => new SelectListItem($"{x.Country},{x.City},{x.Address}", x.Id.ToString()));
            return editVM;
        }
    }
}
