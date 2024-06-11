using PetShelter.Data.Entities;

namespace PetShelter_Boriss.ViewModel
{
    public class PetVaccineEditVM : BaseVM
    {
        public virtual List<Vaccine> PetList { get; set; }
        public virtual List<Vaccine> VaccineList { get; set; }
        public int PetId { get; set; }
        public int VaccineId { get; set; }
    }
}
