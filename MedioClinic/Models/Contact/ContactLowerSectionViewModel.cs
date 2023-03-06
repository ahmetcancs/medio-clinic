using CMS.DocumentEngine.Types.MC;
using MedioClinic.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace MedioClinic.Models.Contact
{
    public class ContactLowerSectionViewModel
    {
        public string Title { get; set; }
        public IEnumerable<ContactLowerSectionItemViewModel> Items { get; set; }

        public static ContactLowerSectionViewModel GetViewModel(ContactLowerSection model,ContactRepository contactRepository)
        {
            if (model == null) 
            {
                return null;
            }
            return new ContactLowerSectionViewModel
            {
                Title = model.Title,
                Items = contactRepository.GetContactLowerSectionItems("/doctors/ourdoctors").Select(x => ContactLowerSectionItemViewModel.GetViewModel(x))
            };
        }
    }
}
