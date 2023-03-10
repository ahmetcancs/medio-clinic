using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.MC;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DocumentFormat.OpenXml.Spreadsheet;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using MedioClinic.Controllers;
using MedioClinic.Models.Doctors;
using MedioClinic.Models.Persons;
using MedioClinic.Repositories;

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
        private readonly PersonsRepository personsRepository;

        public DoctorsController(IPageDataContextRetriever pageDataContextRetriever, IPageUrlRetriever pageUrlRetriever, IPageAttachmentUrlRetriever attachmentUrlRetriever, DoctorsRepository doctorsRepository,PersonsRepository personsRepository)
        {
            this.pageDataContextRetriever = pageDataContextRetriever;
            this.pageUrlRetriever = pageUrlRetriever;
            this.attachmentUrlRetriever = attachmentUrlRetriever;
            this.doctorsRepository = doctorsRepository;
            this.personsRepository = personsRepository;
            
        }
        public IActionResult Index()
        {
            
            var doctorsSection = doctorsRepository.GetDoctorsSections("/doctors").FirstOrDefault();
            var viewModel = new DoctorsViewModel();
           
            viewModel.DoctorsSection = DoctorsSectionViewModel.GetViewModel(doctorsSection, doctorsRepository);
            return View("Doctors",viewModel);
        }
        public IActionResult persons()
        {

            /* List<PersonsViewModel> viewModelList = new List<PersonsViewModel>();
             viewModelList = (List<PersonsViewModel>)personsRepository.GetPersons("/doctors/persons").Select(x => PersonsViewModel.GetViewModel(x));*/

            /*var persons = personsRepository.GetPersons("/doctors/persons").FirstOrDefault();
            var viewModel = new PersonsViewModel();
            viewModel = PersonsViewModel.GetViewModel(persons);
            viewModelList.Add(viewModel);*/
            var trySection = personsRepository.GetPersons("doctors/persons").FirstOrDefault();
            var viewModel = new TryViewModel();

            viewModel = TryViewModel.GetViewModel(trySection, personsRepository);
            return View("Persons", viewModel);
        }
    }
}
