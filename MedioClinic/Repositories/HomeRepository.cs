using CMS.DocumentEngine.Types.MC;
using Kentico.Content.Web.Mvc;
using System.Collections.Generic;

namespace MedioClinic.Repositories
{
    public class HomeRepository : IHomeRepository
    {
        public IEnumerable<HomeTopSection> GetHomeTopSections(string nodeAliasPath)
        {
            return HomeTopSectionProvider.GetHomeTopSections();

        }
        public IEnumerable<HomeLowerSection> GetHomeLowerSections(string nodeAliasPath)
        {
            return HomeLowerSectionProvider.GetHomeLowerSections();

        }
        public IEnumerable<HomeLowerSectionItem> GetHomeLowerSectionItems(string nodeAliasPath)
        {
            return HomeLowerSectionItemProvider.GetHomeLowerSectionItems();

        }
    }
}
