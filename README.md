# Category Management System

### Description

This is a basic .NET Core 8 MVC project that utilizes Entity Framework Core to implement CRUD operations for managing categories. It serves as a straightforward example of building web applications with .NET Core and EF Core.

### Table of Contents

- [Installation](#installation)
- [Usage](#usage)
- [Features](#features)
- [License](#license)

### Installation

Follow these steps to set up and run the project locally:

1. Clone the repository:
   ```bash
   git clone https://github.com/architk004/Bulky_MVC
   ```
2. Navigate to the project directory:
   ```bash
   cd Bulky_MVC
   ```
3. Restore dependencies:
   ```bash
   dotnet restore
   ```
4. Set up the database:
   - Configure the connection string in `appsettings.json`.
   - Apply migrations:
     ```bash
     dotnet ef database update
     ```
5. Run the project:
   ```bash
   dotnet run
   ```

### Usage

1. Open your browser and navigate to `http://localhost:5000` (or the URL displayed in the console).
2. Use the interface to:
   - Add a new category.
   - Update an existing category.
   - Delete a category.
   - View the list of all categories.

### Features

- **Add Categories:** Create new categories with ease.
- **Update Categories:** Edit category details in a user-friendly interface.
- **Delete Categories:** Remove unwanted categories with a single click.
- **List Categories:** View all categories in an organized list.

### License

This project is licensed under the [MIT License](LICENSE).
