# Programming Languages and Frameworks Web App

## Overview

This web application is built using ASP.NET Core MVC and demonstrates the use of Web API with JSON data format. It provides a list of programming languages and frameworks along with their details, including name, type, description, image, and website link. The data is fetched from a JSON file and displayed on the web pages.

## Table of Contents

- [Overview](#overview)
- [Technologies Used](#technologies-used)
- [Project Structure](#project-structure)
- [Installation](#installation)
- [Usage](#usage)
- [Deployment](#Deployment)
- [Contributors](#contributors)


## Technologies Used

- ASP.NET Core
- C# (C-Sharp)
- Razor Pages
- JSON (JavaScript Object Notation)
- Bootstrap (for styling)

## Project Structure

The project follows the following folder structure:

- `Controllers`: Contains the main controller class (`ProductListController.cs`), but it is not used in this assignment.
- `Models`: Contains the `ProgrammingModel.cs` class representing the structure of the programming languages and frameworks data.
- `Pages`: Contains the Razor Pages used in the application.
  - `Index.cshtml`: The home page with project details and technology used.
  - `ProductList.cshtml`: The page displaying the list of programming languages and frameworks.
  - `About.cshtml`: The page that lists the names of the contributors and project information.
- `Services`: Contains the `ProgrammingService.cs` class responsible for reading data from the JSON file and providing it to the pages.

## Installation

To run the project locally, follow these steps:

1. Clone the repository to your local machine.
2. Open the project in Visual Studio 2022 or any compatible IDE.
3. Build the solution to restore the NuGet packages.
4. Run the application using IIS Express or any other local server.

## Usage

After running the application, open your web browser and navigate to the following URLs:

- Home Page: `https://localhost:port/`
- Product List Page: `https://localhost:port/ProductList`
- About Page: `https://localhost:port/About`

On the Product List page, you will see a table displaying the list of programming languages and frameworks with their details. Each row includes the ID, name, type, description, image, and a link to the respective website.

## Deployment

This project is deployed on Azure. You can access it using the following link:
[https://assignment02-aspdotnet.azurewebsites.net](https://assignment02-aspdotnet.azurewebsites.net)

## Contributors

- Shrey Patel (GitHub: [Shrey-Patel](https://github.com/ShreyPatel7))
