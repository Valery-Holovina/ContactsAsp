using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebApp.Models;
using MyWebApp.Services;

namespace MyWebApp.Pages
{
    public class ContactsModel : PageModel
    {
        public List<Contact> Contacts { get; set; } = new();

        public void OnGet()
        {
            Contacts = ContactStore.Contacts;
        }
    }
}