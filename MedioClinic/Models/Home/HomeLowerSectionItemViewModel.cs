using CMS.DocumentEngine.Types.MC;
using MedioClinic.Helpers;

namespace MedioClinic.Models.Home
{
    public class HomeLowerSectionItemViewModel
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public static HomeLowerSectionItemViewModel GetViewModel(HomeLowerSectionItem model) 
        { 
            if (model == null)
            {
                return null;
            }
            return new HomeLowerSectionItemViewModel
            { 
            
                Image = MedioClinicAttachmentHelper.GetFullPath(model.Image),
                Title = model.Title,
                Description = model.Description            
            };
        }
    }
}
