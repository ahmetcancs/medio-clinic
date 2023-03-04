using CMS.DocumentEngine.Types.MC;
using Kentico.Content.Web.Mvc;
using System.Collections.Generic;

namespace MedioClinic.Repositories.Profiles
{
    public class ProfileRepository
    {
        private readonly IPageRetriever pageRetriever;
        public ProfileRepository(IPageRetriever pageRetriever)
        {
            this.pageRetriever = pageRetriever;
        }
        
        public IEnumerable<Profile> GetProfiles(string nodeAliasPath)
        {
            return ProfileProvider.GetProfiles();

        }
    }
}
