using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.MC;
using MedioClinic.Helpers;
using System;

namespace MedioClinic.Models.Doctors
{
    public class DoctorsSectionItemViewModel
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Badge { get; set; }
        public string Button { get; set; }
        public string ButtonTitle { get; set; }

       
        public static DoctorsSectionItemViewModel GetViewModel(DoctorsSectionItem model)
        {
            if (model == null) 
            {
            
                return null;
            
            }
            return new DoctorsSectionItemViewModel
            {


                Image = MedioClinicAttachmentHelper.GetFullPath(model.Image),
                Title = model.Title,
                Description = model.Description,
                Badge = model.Badge,
                Button= model.Button,
                ButtonTitle= model.ButtonTitle
            };
        }
    }
}
