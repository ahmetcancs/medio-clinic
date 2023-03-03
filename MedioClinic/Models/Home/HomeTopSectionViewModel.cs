using CMS.DocumentEngine.Types.MC;

namespace MedioClinic.Models.Home
{
    public class HomeTopSectionViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Button { get; set; }
        public string ButtonTitle { get; set; }

        public static HomeTopSectionViewModel GetViewModel(HomeTopSection model) 
        {
            if (model == null)
            {
                return null;
            }
            return new HomeTopSectionViewModel
            {
                Title= model.Title,
                Description= model.Description,
                Button= model.Button,
                ButtonTitle= model.ButtonTitle
            };
                
        }
    }
}
