using ProgrammingLanguages.Models; // Importing the namespace for ProgrammingModel
using System.Text.Json; // Importing the namespace for JsonSerializer

namespace ProgrammingLanguages.Services
{
    public class ProgrammingService
    {
        // Constructor that takes the IWebHostEnvironment as a parameter to access the web host environment
        public ProgrammingService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment; // Setting the WebHostEnvironment property to the provided webHostEnvironment
        }

        // Property to store the IWebHostEnvironment
        public IWebHostEnvironment WebHostEnvironment { get; }

        // Property to get the file path of the JSON data file inside the wwwroot
        private string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "Data", "ProgrammingData.json");

        // Method to retrieve the list of programming languages and frameworks from the JSON data file
        public IEnumerable<ProgrammingModel> GetProducts()
        {
            // Using statement ensures the proper disposal of resources after use (in this case, the jsonFileReader)
            using var jsonFileReader = File.OpenText(JsonFileName); // Open the JSON data file for reading

            // Deserializing the JSON data read from the file into an array of ProgrammingModel objects
            // The PropertyNameCaseInsensitive option allows deserialization to be case-insensitive
            // The "!" after the Deserialize call means the method will return a non-null value
            return JsonSerializer.Deserialize<ProgrammingModel[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                })!;
        }
    }
}
