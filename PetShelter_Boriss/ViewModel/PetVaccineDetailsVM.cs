﻿using PetShelter.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShelter_Boriss.ViewModel
{
    public class PetVaccineDetailsVM : BaseVM
    {
        public int PetId { get; set; }

        public virtual Pet Pet { get; set; }

        public int VaccineId { get; set; }

        public virtual Vaccine Vaccine { get; set; }
    }
}
