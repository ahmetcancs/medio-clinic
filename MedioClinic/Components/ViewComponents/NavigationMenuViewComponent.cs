using CMS.DocumentEngine.Types.MC;
using CMS.DocumentEngine;
using Kentico.Content.Web.Mvc;
using MedioClinic.Models.Menu;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace MedioClinic.Components.ViewComponents
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private readonly IPageRetriever pageRetriever;
        private readonly IPageUrlRetriever pageUrlRetriever;

        private const string MENU_SUBSECTION = "/Menu";

        public NavigationMenuViewComponent(IPageRetriever pageRetriever, IPageUrlRetriever pageUrlRetriever)
        {
            // Initializes instances of required services using dependency injection
            this.pageRetriever = pageRetriever;
            this.pageUrlRetriever = pageUrlRetriever;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Gets all pages under the 'Navigation' node in the content tree
            IEnumerable<NavigationItem> navigationPages = await pageRetriever.RetrieveAsync<NavigationItem>(
                    query => query
                         .Path(MENU_SUBSECTION, PathTypeEnum.Children)
                         .OrderByAscending("NodeOrder"),
                    cache => cache
                         .Key($"{nameof(NavigationMenuViewComponent)}|{nameof(InvokeAsync)}|navigationpages")
                         // Flushes the cache when a new navigation item is created or the page order changes
                         .Dependencies((pages, builder) => builder.PagePath(MENU_SUBSECTION, PathTypeEnum.Children).PageOrder())
                         .Expiration(System.TimeSpan.FromDays(1), useSliding: true));

            // Gets all pages referenced by the retrieved navigation items
            IEnumerable<TreeNode> linkToPages = await pageRetriever.RetrieveAsync<TreeNode>(
                    query => query
                         .WhereIn("NodeGUID", navigationPages.Select(i => i.Fields.LinkTo.First().NodeGUID).ToList())
                         .GetEnumerableTypedResult(),
                    cache => cache
                         .Key($"{nameof(NavigationMenuViewComponent)}|{nameof(InvokeAsync)}|linkToPages")
                         // Flushes the cache when the page data changes (could contain a URL slug update)
                         .Dependencies((pages, builder) => builder.Pages(pages).PagePath(MENU_SUBSECTION))
                         .Expiration(System.TimeSpan.FromDays(1), useSliding: true));

            // Matches both collections on 'NodeGUID,' ensuring order from the first collection
            IEnumerable<NavigationItemViewModel> menuItems = navigationPages.Join(
                         linkToPages,
                         c1 => c1.Fields.LinkTo.First().NodeGUID,
                         c2 => c2.NodeGUID,
                         (c1, c2) => new NavigationItemViewModel
                         {
                             MenuItemRelativeUrl = pageUrlRetriever.Retrieve(c2).RelativePath,
                             MenuItemText = c1.DocumentName
                         });

            return View(menuItems);
        }
    }
}