using System.ComponentModel.DataAnnotations;

namespace YourNamespace.Models
{
    public class CreatePersonViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string City { get; set; }
    }
}

