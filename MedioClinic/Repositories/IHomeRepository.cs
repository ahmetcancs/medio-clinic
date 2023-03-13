using CMS.DocumentEngine.Types.MC;
using System.Collections.Generic;

namespace MedioClinic.Repositories
{
    public interface IHomeRepository
    {
        IEnumerable<HomeTopSection> GetHomeTopSections(string nodeAliasPath);
        IEnumerable<HomeLowerSection> GetHomeLowerSections(string nodeAliasPath);
        IEnumerable<HomeLowerSectionItem> GetHomeLowerSectionItems(string nodeAliasPath);
    }
}
