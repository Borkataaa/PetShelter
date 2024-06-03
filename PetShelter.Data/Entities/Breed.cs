﻿namespace PetShelter.Data.Entities
{
    public class Breed : BaseEntity
    {
        public Breed()
        {
            this.Pets = new List<Pet>();
        }
                
        public string Name { get; set; }
                
        public BreedSize Size { get; set; }

        public virtual List<Pet> Pets { get; set; }
    }
}
