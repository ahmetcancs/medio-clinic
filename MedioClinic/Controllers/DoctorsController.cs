using CMS.DocumentEngine.Types.MC;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using MedioClinic.Controllers;
using MedioClinic.Models.Doctors;
using MedioClinic.Repositories;

using Microsoft.AspNetCore.Mvc;
using System.Linq;

[assembly: RegisterPageRoute(Doctors.CLASS_NAME, typeof(DoctorsController), ActionName = "Index")]

namespace MedioClinic.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly IPageDataContextRetriever pageDataContextRetriever;
        private readonly IPageUrlRetriever pageUrlRetriever;
        private readonly IPageAttachmentUrlRetriever attachmentUrlRetriever;
        private readonly DoctorsRepository doctorsRepository;


        public DoctorsController(IPageDataContextRetriever pageDataContextRetriever, IPageUrlRetriever pageUrlRetriever, IPageAttachmentUrlRetriever attachmentUrlRetriever, DoctorsRepository doctorsRepository)
        {
            this.pageDataContextRetriever = pageDataContextRetriever;
            this.pageUrlRetriever = pageUrlRetriever;
            this.attachmentUrlRetriever = attachmentUrlRetriever;
            this.doctorsRepository = doctorsRepository;
            
        }
        public IActionResult Index()
        {
            var special = doctorsRepository.GetSpecials("/doctors/profiles").FirstOrDefault();
            var doctorsSection = doctorsRepository.GetDoctorsSections("/doctors").FirstOrDefault();
            var viewModel = new DoctorsViewModel();
            viewModel.Special = SpecialViewModel.GetViewModel(special);
            viewModel.DoctorsSection = DoctorsSectionViewModel.GetViewModel(doctorsSection, doctorsRepository);
            return View("Doctors",viewModel);
        }
       
    }
}
