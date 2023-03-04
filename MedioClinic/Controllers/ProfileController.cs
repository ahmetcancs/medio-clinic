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
        public IActionResult Index(Delegate Request)
        {
            var path = Request.ToString();
            var profile = profileRepository.GetProfiles(path).FirstOrDefault();
            var viewmodel = new ProfileViewModel();
            
            viewmodel = ProfileViewModel.GetViewModel(profile);
            return View("Profile", viewmodel);
        }
    }
}
