using CMS.DocumentEngine.Types.MC;
using System.Collections.Generic;

namespace MedioClinic.Repositories
{
    public interface IDoctorsRepository
    {
        IEnumerable<DoctorsSection> GetDoctorsSections(string nodeAliasPath);
        IEnumerable<DoctorsSectionItem> GetDoctorsSectionItems(string nodeAliasPath);
    }
}
