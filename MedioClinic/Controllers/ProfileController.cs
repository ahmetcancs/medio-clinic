using CMS.DocumentEngine.Types.MC;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using MedioClinic.Controllers;
using MedioClinic.Models.Doctors;
using MedioClinic.Repositories.Profiles;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

[assembly: RegisterPageRoute(Profile.CLASS_NAME, typeof(ProfileController), ActionName = "Index")]
namespace MedioClinic.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IPageDataContextRetriever pageDataContextRetriever;
        private readonly IPageUrlRetriever pageUrlRetriever;
        private readonly IPageAttachmentUrlRetriever attachmentUrlRetriever;
        private readonly ProfileRepository profileRepository;

        public ProfileController(IPageDataContextRetriever pageDataContextRetriever, IPageUrlRetriever pageUrlRetriever, IPageAttachmentUrlRetriever attachmentUrlRetriever, ProfileRepository profileRepository)
        {
            this.pageDataContextRetriever = pageDataContextRetriever;
            this.pageUrlRetriever = pageUrlRetriever;
            this.attachmentUrlRetriever = attachmentUrlRetriever;
            this.profileRepository = profileRepository;
        }
        public IActionResult Index()
        {
            
            var profile = profileRepository.GetProfiles("/profile").FirstOrDefault();
            var viewModel = new ProfileViewModel();
            
            viewModel = ProfileViewModel.GetViewModel(profile);
            return View("Profile", viewModel);
        }
    }
    
}
