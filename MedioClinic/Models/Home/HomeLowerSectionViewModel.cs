using CMS.DocumentEngine.Types.MC;
using MedioClinic.Repositories.Home;
using System.Collections.Generic;
using System.Linq;

namespace MedioClinic.Models.Home
{
    public class HomeLowerSectionViewModel
    {
        

        public IEnumerable<HomeLowerSectionItemViewModel> Items { get; set; }
        public static HomeLowerSectionViewModel GetViewModel(HomeLowerSection model, HomeRepository homeRepository) 
        {
            if (model == null)
            {
                return null;
            }
            return new HomeLowerSectionViewModel
            {
               
                Items = homeRepository.GetHomeLowerSectionItems("/home/lowersection").Select(x => HomeLowerSectionItemViewModel.GetViewModel(x))

            };
        }
    }
}
