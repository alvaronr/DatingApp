using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You muust specify password between 4 and 4 characters")]
        public string Password { get; set; }
    }
}