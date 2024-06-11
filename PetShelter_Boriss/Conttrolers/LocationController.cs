using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Services.Contracts;
using PetShelter_Boriss.ViewModel;

namespace PetShelter_Boriss.Conttrolers
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Admin, Employee")]
    public class LocationController : BaseCrudController<LocationDto, ILocationRepository, IIocationServices, LocationEditVM, LocationDetailsVM>
    {
        public LocationController(IIocationServices service, IMapper mapper) : base(service, mapper)
        {

        }
    }
}
