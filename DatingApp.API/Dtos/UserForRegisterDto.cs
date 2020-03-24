using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(20,MinimumLength =8 , ErrorMessage="Your password must be above 8 characters")]
        public string Password { get; set; }
    }
}