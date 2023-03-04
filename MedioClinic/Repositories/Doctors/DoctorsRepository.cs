﻿using CMS.DocumentEngine.Types.MC;
using Kentico.Content.Web.Mvc;
using System.Collections.Generic;

namespace MedioClinic.Repositories.Doctors
{
    public class DoctorsRepository
    {
        private readonly IPageRetriever pageRetriever;
        public DoctorsRepository(IPageRetriever pageRetriever)
        {
            this.pageRetriever = pageRetriever;
        }
        public IEnumerable<DoctorsSection> GetDoctorsSections(string nodeAliasPath)
        {
            return DoctorsSectionProvider.GetDoctorsSections();

        }
        public IEnumerable<DoctorsSectionItem> GetDoctorsSectionItems(string nodeAliasPath)
        {
            return DoctorsSectionItemProvider.GetDoctorsSectionItems();

        }
       
    }
}