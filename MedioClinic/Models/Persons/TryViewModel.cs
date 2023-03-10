using MedioClinic.Helpers;
using MedioClinic.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace MedioClinic.Models.Persons
{
    public class TryViewModel
    {
        public IEnumerable<PersonsViewModel> Items { get; set; }
       
        public static TryViewModel GetViewModel(CMS.DocumentEngine.Types.MC.Persons model,PersonsRepository personsRepository)
        {
            if (model == null)
            {
                return null;
            }

            return new TryViewModel
            {
                Items = personsRepository.GetPersons("/doctors/persons").Select(x => PersonsViewModel.GetViewModel(x))
                
            };
        }
    }
}
