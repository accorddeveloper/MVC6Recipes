using System.ComponentModel.DataAnnotations;

namespace Recipe06.Web.Models
{
    public class Contact
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }


    }
}
