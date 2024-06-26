﻿
using PetShelter.Data.Enums;

namespace PetShelter.Shared.Dtos
{
    public class BreedDto : BaseModel
    {
        public BreedDto()
        {
            this.Pets = new List<PetDto>();
        }

        public string Name { get; set; }

        public BreedSize Size { get; set; }

        public List<PetDto> Pets { get; set; }
    }
}
