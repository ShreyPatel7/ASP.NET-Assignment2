using System.Collections.Generic; // Importing the namespace for IEnumerable<T> and other collection-related types
using Microsoft.AspNetCore.Mvc.RazorPages; // Importing the namespace for PageModel class
using ProgrammingLanguages.Models; // Importing the namespace for ProgrammingModel
using ProgrammingLanguages.Services; // Importing the namespace for ProgrammingService

namespace ProgrammingLanguages.Pages // Namespace for Razor Pages
{
    public class ProductListModel : PageModel // Razor Page model class that inherits from PageModel
    {
        private readonly ProgrammingService _programmingService; // Private field to store an instance of ProgrammingService

        // Constructor that takes an instance of ProgrammingService as a parameter
        public ProductListModel(ProgrammingService programmingService)
        {
            _programmingService = programmingService; // Assigning the provided programmingService to the _programmingService field
        }

        // Property to store a collection of ProgrammingModel objects
        public IEnumerable<ProgrammingModel> Products { get; private set; }

        // Handler method that runs when the page is requested (HTTP GET)
        public void OnGet()
        {
            // Calling the GetProducts method of _programmingService to retrieve a list of ProgrammingModel objects
            Products = _programmingService.GetProducts();
        }
    }
}
