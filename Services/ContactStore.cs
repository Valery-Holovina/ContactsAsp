using MyWebApp.Models;

namespace MyWebApp.Services
{
    public static class ContactStore
    {
        public static List<Contact> Contacts { get; set; } = new();
    }
}