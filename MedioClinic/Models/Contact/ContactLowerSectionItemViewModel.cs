using CMS.DocumentEngine.Types.MC;
using MedioClinic.Helpers;
using MedioClinic.Models.Doctors;

namespace MedioClinic.Models.Contact
{
    public class ContactLowerSectionItemViewModel
    {
        public string Image { get; set; }
        public bool Badge { get; set; }
        public string Branch { get; set; }
        


        public static ContactLowerSectionItemViewModel GetViewModel(ContactLowerSectionItem model)
        {
            if (model == null)
            {

                return null;

            }
            return new ContactLowerSectionItemViewModel
            {
                Image = MedioClinicAttachmentHelper.GetFullPath(model.Image),
                Badge = model.Badge,
                Branch = model.Branch
            };
        }
    }
}
