using CMS.DocumentEngine.Types.MC;
using System.Collections.Generic;

namespace MedioClinic.Repositories
{
    public interface IContactRepository
    {
        IEnumerable<ContactTopSection> GetContactTopSections(string nodeAliasPath);
        IEnumerable<ContactLowerSection> GetContactLowerSections(string nodeAliasPath);
        IEnumerable<ContactLowerSectionItem> GetContactLowerSectionItems(string nodeAliasPath);
    }
}
