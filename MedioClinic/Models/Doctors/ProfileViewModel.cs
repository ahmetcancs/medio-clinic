using CMS.DocumentEngine.Types.MC;
using MedioClinic.Helpers;
using System;

namespace MedioClinic.Models.Doctors
{
    public class ProfileViewModel
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public bool Badge { get; set; }
        public string Education { get; set; }
        public string DescriptionTitle { get; set; }
        public string Description { get; set; }
        

        
        public static ProfileViewModel GetViewModel(Profile model)
        {
            if (model == null)
            {

                return null;

            }
            return new ProfileViewModel
            {
                Image = MedioClinicAttachmentHelper.GetFullPath(model.Image),
                Title = model.Title,
                Badge = model.Badge,
                Education = model.Education,
                DescriptionTitle = model.DescriptionTitle,
                Description = model.Description
            };
        }

    }
}
