using CMS.DocumentEngine.Types.MC;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using MedioClinic.Controllers;
using MedioClinic.Models.Home;
using MedioClinic.Repositories.Home;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

[assembly: RegisterPageRoute(Home.CLASS_NAME, typeof(HomeController), ActionName = "Index")]
namespace MedioClinic.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPageDataContextRetriever pageDataContextRetriever;
        private readonly IPageUrlRetriever pageUrlRetriever;
        private readonly IPageAttachmentUrlRetriever attachmentUrlRetriever;
        private readonly HomeRepository homeRepository;

        public HomeController(IPageDataContextRetriever pageDataContextRetriever, IPageUrlRetriever pageUrlRetriever, IPageAttachmentUrlRetriever attachmentUrlRetriever, HomeRepository homeRepository)
        {
            this.pageDataContextRetriever = pageDataContextRetriever;
            this.pageUrlRetriever = pageUrlRetriever;
            this.attachmentUrlRetriever = attachmentUrlRetriever;
            this.homeRepository = homeRepository;
        }
        public IActionResult Index()
        {
            var homeLowerSection = homeRepository.GetHomeLowerSections("/home/lowersection").FirstOrDefault();
            var homeTopSection = homeRepository.GetHomeTopSections("/home/topsection").FirstOrDefault();
            var viewModel = new HomeViewModel();

            viewModel.HomeLowerSection = HomeLowerSectionViewModel.GetViewModel(homeLowerSection,homeRepository);
            viewModel.HomeTopSection = HomeTopSectionViewModel.GetViewModel(homeTopSection);
            return View("Home",viewModel);
        }
    }
}
