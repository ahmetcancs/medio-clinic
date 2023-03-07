using CMS.DocumentEngine.Types.MC;
using CMS.DocumentEngine;
using Kentico.Content.Web.Mvc;
using MedioClinic.Models.Menu;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using CMS.Core;

namespace MedioClinic.Components.ViewComponents
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        /*   private readonly IPageRetriever pageRetriever;
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

               return View(menuItems);*/
        private readonly IPageRetriever pageRetriever;
        private readonly IPageUrlRetriever urlRetriever;

        public NavigationMenuViewComponent()
        {
            // Initializes instances of required services
            // NOTE: This method of instantiating services is not recommended for 
            // real-world projects and is only used for the sake of brevity in this tutorial.
            // Instead, we recommend configuring a dependency injection container to resolve 
            // object dependencies (e.g., Autofac). See the Xperience documentation for details.
            pageRetriever = Service.Resolve<IPageRetriever>();
            urlRetriever = Service.Resolve<IPageUrlRetriever>();
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Retrieves a collection of page objects with data for the menu (pages of all page types)
            IEnumerable<TreeNode> menuItems = await pageRetriever.RetrieveAsync<TreeNode>(query => query
                                                    // Selects pages that have the 'Show in menu" flag enabled
                                                    .MenuItems()
                                                    // Only loads pages from the first level of the site's content tree
                                                    .NestingLevel(1)
                                                    // Filters the result to only include required columns
                                                    .Columns("DocumentName", "NodeID", "NodeSiteID")
                                                    // Uses the menu item order from the content tree
                                                    .OrderByAscending("NodeOrder"));

            // Creates a collection of view models based on the menu item data
            IEnumerable<NavigationItemViewModel> model = menuItems.Select(item => new NavigationItemViewModel()
            {
                // Gets the name of the page as the menu item caption text
                MenuItemText = item.DocumentName,
                // Retrieves the URL for the page (as a relative virtual path)
                MenuItemRelativeUrl = urlRetriever.Retrieve(item).RelativePath
            });

            return View(model);
        }
    }
}