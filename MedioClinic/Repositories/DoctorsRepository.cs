using CMS.DocumentEngine.Types.MC;
using Kentico.Content.Web.Mvc;
using System.Collections.Generic;

namespace MedioClinic.Repositories
{
    public class DoctorsRepository : IDoctorsRepository
    {
        public IEnumerable<DoctorsSection> GetDoctorsSections(string nodeAliasPath)
        {
            return DoctorsSectionProvider.GetDoctorsSections();

        }
        public IEnumerable<DoctorsSectionItem> GetDoctorsSectionItems(string nodeAliasPath)
        {
            return DoctorsSectionItemProvider.GetDoctorsSectionItems();

        }
       
    }
}