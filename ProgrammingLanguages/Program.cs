using ProgrammingLanguages.Services; // Importing the namespace for the ProgrammingService

namespace ProgrammingLanguages
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Creating a new instance of WebApplicationBuilder
            var builder = WebApplication.CreateBuilder(args);

            // Adding Razor Pages services to the dependency injection container
            builder.Services.AddRazorPages();

            // Adding the ProgrammingService as a transient service to the dependency injection container
            builder.Services.AddTransient<ProgrammingService>();

            // Building the application using the provided configuration
            var app = builder.Build(); 

            if (!app.Environment.IsDevelopment())
            {
                // If the application is not in development environment, then handling exceptions and use HTTPS Strict Transport Security (HSTS)
                app.UseExceptionHandler("/Error"); // Handling exceptions by redirecting to the /Error page
                app.UseHsts(); // Using HTTP Strict Transport Security (HSTS) to enforce HTTPS
            }

            // Redirecting HTTP requests to HTTPS
            app.UseHttpsRedirection(); 
            app.UseStaticFiles(); // Enabling serving static files like images, CSS, and JavaScript

            // Enabling routing middleware to handle incoming requests
            app.UseRouting();

            // Using authorization middleware for authentication and authorization
            app.UseAuthorization();

            // Mapping Razor Pages endpoints for the application
            app.MapRazorPages();

            // Starting the application
            app.Run(); 
        }
    }
}
