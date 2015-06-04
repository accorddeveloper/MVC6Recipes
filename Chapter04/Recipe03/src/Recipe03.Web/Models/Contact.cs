using System.ComponentModel.DataAnnotations;

namespace Recipe03.Web.Models
{
    public class Contact
    {

        public string Name { get; set; }


        public string Email { get; set; }

        
        public string Phone { get; set; }

        [Display(Name="Allow Us to send you SPAM?")]
        public bool AllowContactAboutOffers { get; set; }

        public string FavoriteColor { get; set; }
    }
}
