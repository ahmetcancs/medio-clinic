using CMS.DocumentEngine.Types.MC;
using MedioClinic.Models.Home;
using MedioClinic.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace MedioClinic.Models.Doctors
{
    public class DoctorsSectionViewModel
    {
        public string Title { get; set; }
        public IEnumerable<DoctorsSectionItemViewModel> Items { get; set; }
        public static DoctorsSectionViewModel GetViewModel(DoctorsSection model, DoctorsRepository doctorsRepository)
        {
            if (model == null)
            {
                return null;
            }
            return new DoctorsSectionViewModel
            {
                Title = model.Title,
                Items = doctorsRepository.GetDoctorsSectionItems("/doctors/ourdoctors").Select(x => DoctorsSectionItemViewModel.GetViewModel(x))

            };
        }
    }
}
