using CMS.DocumentEngine.Types.MC;
using Kentico.Content.Web.Mvc;
using System.Collections.Generic;

namespace MedioClinic.Repositories
{
    public class ContactRepository : IContactRepository
    {

        public IEnumerable<ContactTopSection> GetContactTopSections(string nodeAliasPath)
        {
            return ContactTopSectionProvider.GetContactTopSections();

        }
        public IEnumerable<ContactLowerSection> GetContactLowerSections(string nodeAliasPath)
        {
            return ContactLowerSectionProvider.GetContactLowerSections();

        }
        public IEnumerable<ContactLowerSectionItem> GetContactLowerSectionItems(string nodeAliasPath)
        {
            return ContactLowerSectionItemProvider.GetContactLowerSectionItems();

        }
    }
}
