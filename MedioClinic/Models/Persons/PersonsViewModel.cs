using Kentico.Content.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;
using CMS.DocumentEngine.Types.MC;
using DocumentFormat.OpenXml.EMMA;
using MedioClinic.Helpers;

namespace MedioClinic.Models.Persons
{
    public class PersonsViewModel
    {

        public string Image { get; set; }
        public string Title { get; set; }
        public bool Badge { get; set; }
        public string Education { get; set; }
        public string DescriptionTitle { get; set; }
        public string Description { get; set; }

       
        public static PersonsViewModel GetViewModel(CMS.DocumentEngine.Types.MC.Persons model)
        {
            if (model == null)
            {
                return null;
            }

            return new PersonsViewModel
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
