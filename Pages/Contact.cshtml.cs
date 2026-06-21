using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebApp.Models;
using MyWebApp.Services;

namespace MyWebApp.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public Contact Contact { get; set; } = new();

        public string? Message { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            ContactStore.Contacts.Add(Contact);

            Message = "Данные успешно получены!";
            ModelState.Clear();
            Contact = new Contact();

            return Page();
        }
    }
}