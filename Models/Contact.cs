using System.ComponentModel.DataAnnotations;

namespace MyWebApp.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "Имя обязательно")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email обязателен")]
        [EmailAddress(ErrorMessage = "Некорректный email")]
        public string Email { get; set; } = string.Empty;
    }
}