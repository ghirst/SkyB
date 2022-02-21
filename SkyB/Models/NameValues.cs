using System.ComponentModel.DataAnnotations;

namespace SkyB.Models
{
    public class NameValuesModel
    {
        [Required]
        //The name cannot contain numerical values
        public string? Name { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }

        public string? RetypePassword { get; set; }
        public string? Email { get; set; }
        public DateTime DOB { get; set; } 
    }
     
}