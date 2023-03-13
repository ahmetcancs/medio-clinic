using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.MC;
using Kentico.Content.Web.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace MedioClinic.Repositories
{
    public class PersonsRepository : IPersonRepository
    {

        public IEnumerable<Persons> GetPersons(string nodeAliasPath)
        {
            return PersonsProvider.GetPersons();

        }
        /*
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonsRepository"/> class.
        /// </summary>
        /// <param name="pageRetriever">The pages retriever.</param>
        public PersonsRepository(IPageRetriever pageRetriever, IPageDataContextRetriever pageDataContextRetriever)
        {
            this.pageRetriever = pageRetriever;
            this.pageDataContextRetriever = pageDataContextRetriever;
        }


        /// <summary>
        /// Returns an enumerable collection of articles ordered by the date of publication. The most recent articles come first.
        /// </summary>
        /// <param name="nodeAliasPath">The node alias path of the articles section in the content tree.</param>
        /// <param name="count">The number of articles to return. Use 0 as value to return all records.</param>
        public IEnumerable<Profile> GetProfiles(string nodeAliasPath, int count = 0)
        {
            return pageRetriever.Retrieve<Profile>(
                query => query
                    .Path(nodeAliasPath, PathTypeEnum.Children)
                    .TopN(count)
                    .OrderByDescending("DocumentPublishFrom"),
                cache => cache
                    .Key($"{nameof(PersonsRepository)}|{nameof(GetProfiles)}|{nodeAliasPath}|{count}")
                    // Include path dependency to flush cache when a new child page is created.
                    .Dependencies((_, builder) => builder.PagePath(nodeAliasPath, PathTypeEnum.Children)));
        }


       public virtual Profile GetCurrent()
        {
            var page = pageDataContextRetriever.Retrieve<Profile>().Page;

            return pageRetriever.Retrieve<Profile>(
                query => query
                    .WhereEquals("NodeID", page.NodeID),
                cache => cache
                    .Key($"{nameof(ProfileRepository)}|{nameof(GetCurrent)}|{page.NodeID}")
                    .Dependencies((profiles, deps) => deps.Pages(profiles.First().Fields.RelatedProfiles)))
                .First();
        }*/
    }
}
