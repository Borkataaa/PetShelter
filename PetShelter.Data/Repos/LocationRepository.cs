﻿using AutoMapper;
using PetShelter.Data.Entities;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShelter.Shared.Atributes;

namespace PetShelter.Data.Repos
{
    [AutoBind]

    public class LocationRepository : BaseRepository<Location, LocationDto>, ILocationRepository

    {
       public LocationRepository(PetShelterDbContext context, IMapper mapper) : base(context, mapper)
        {
            
        }

        public Task<IEnumerable<LocationDto>> GetAllActiveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
