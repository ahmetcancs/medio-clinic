using CMS.DocumentEngine.Types.MC;
using Kentico.Content.Web.Mvc;
using MedioClinic.Models.Contact;
using MedioClinic.Models.Home;
using MedioClinic.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace MedioClinic.Controllers
{
    public class ContactController : Controller
    {
        private readonly IPageDataContextRetriever pageDataContextRetriever;
        private readonly IPageUrlRetriever pageUrlRetriever;
        private readonly IPageAttachmentUrlRetriever attachmentUrlRetriever;
        private readonly ContactRepository contactRepository;


        public ContactController(IPageDataContextRetriever pageDataContextRetriever, IPageUrlRetriever pageUrlRetriever, IPageAttachmentUrlRetriever attachmentUrlRetriever, ContactRepository contactRepository)
        {
            this.pageDataContextRetriever = pageDataContextRetriever;
            this.pageUrlRetriever = pageUrlRetriever;
            this.attachmentUrlRetriever = attachmentUrlRetriever;
            this.contactRepository = contactRepository;

        }
        public IActionResult Index()
        {
            var contactTopSection = contactRepository.GetContactTopSections("/contact").FirstOrDefault();
            var contactLowerSection = contactRepository.GetContactLowerSections("/contact").FirstOrDefault();
            var viewModel = new ContactViewModel();

            viewModel.ContactTopSection = ContactTopSectionViewModel.GetViewModel(contactTopSection);
            viewModel.ContactLowerSection = ContactLowerSectionViewModel.GetViewModel(contactLowerSection, contactRepository);
            return View("Contact", viewModel);
        }
    }
}
