using System.Text.Json.Serialization; // Importing the namespace for JsonSerializer attribute

namespace ProgrammingLanguages.Models
{
    public class ProgrammingModel
    {
        // Properties representing the data fields of a programming language or framework

        public int Id { get; set; } // Unique identifier for the programming language or framework

        public string Name { get; set; } // Name of the programming language or framework

        public string Type { get; set; } // Type or category of the programming language or framework

        public string Description { get; set; } // Description of the programming language or framework

        [JsonPropertyName("image")]
        public string Image { get; set; } // URL to the image representing the programming language or framework

        public string Website { get; set; } // URL to the official website of the programming language or framework
    }
}
