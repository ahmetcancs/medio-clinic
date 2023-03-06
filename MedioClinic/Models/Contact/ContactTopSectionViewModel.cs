using CMS.DocumentEngine.Types.MC;


namespace MedioClinic.Models.Contact
{
    public class ContactTopSectionViewModel
    {
        public string HeaderTitle { get; set; }
        public string SubTitle  { get; set; }
        public string Description { get; set; }
        public string AddressDescription { get; set; }

        public static ContactTopSectionViewModel GetViewModel(ContactTopSection model)
        {
            if (model == null)
            {
                return null;
            }
            return new ContactTopSectionViewModel
            {
                HeaderTitle = model.HeaderTitle,
                SubTitle = model.SubTitle,
                Description = model.Description,
                AddressDescription = model.AddressDescription
            };

        }
    }
}
