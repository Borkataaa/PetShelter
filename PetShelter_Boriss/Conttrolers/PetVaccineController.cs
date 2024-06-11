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
    public class PetVaccineController : BaseCrudController<PetVaccineDto, IPetVaccineRepository, IPetVaccineService, PetVaccineDetailsVM, PetVaccineEditVM>
    {
        public PetVaccineController(IPetVaccineService service, IMapper mapper) : base(service, mapper)
        {

        }
    }
}
