using CMS.DocumentEngine.Types.MC;
using Kentico.Content.Web.Mvc;
using System.Collections.Generic;

namespace MedioClinic.Repositories.Home
{
    public class HomeRepository
    {
        private readonly IPageRetriever pageRetriever;
        public HomeRepository(IPageRetriever pageRetriever)
        {
            this.pageRetriever = pageRetriever;
        }

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
