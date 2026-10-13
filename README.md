Employee Transport Management System (ETMSystem)
Developed by Katleho Molefe

A .NET 10 console application designed to manage employee transport operations, including clients, travel records, contracts, drivers, and user accounts.

The application follows a layered architecture and uses Entity Framework Core for database access and Spectre.Console for an enhanced command-line user experience.

Features
✅ User Registration and Authentication

✅ Client Management (Create, Read, Update, Delete)

✅ Travel Management

✅ Contract Management

✅ Driver Management

✅ Password Security using BCrypt

✅ SQL Server Database Integration

✅ Dependency Injection

✅ Repository Pattern Implementation

✅ Layered Architecture

Architecture
The system follows a layered architecture:

View
 ↓
Controller
 ↓
Service
 ↓
Repository
 ↓
Entity Framework Core
 ↓
SQL Server
Project Structure
ETMSystem
│
├── Data
├── Models
├── Repository
├── Service
├── Controller
├── View
└── Program.cs
Technology Stack
C#
.NET 10
Entity Framework Core 10
SQL Server
Spectre.Console
BCrypt.Net-Next
Microsoft Dependency Injection
Project Structure
Data
Contains the Entity Framework Core DbContext configuration and database access layer.

Models
Contains the application's domain entities:

Client
User
Driver
Contract
Travel
Repository
Implements the Repository Pattern and data access operations.

Service
Contains the business logic layer.

Controller
Handles communication between services and views.

View
Console-based user interface built using Spectre.Console.

Prerequisites
Before running the application, ensure the following are installed:

.NET 10 SDK
SQL Server or SQL Server LocalDB
Visual Studio 2022 or later
Configuration
Configure your connection string through application configuration rather than hardcoding values.

Example:

{
  "ConnectionStrings": {
    "DefaultConnection": "YOUR_CONNECTION_STRING"
  }
}
Running the Application
Visual Studio
Open ETMSystem.slnx
Build the solution
Press F5 to run
Command Line
dotnet restore
dotnet build
dotnet run
Main Entry Points
Component	Purpose
Program.cs	Configures Dependency Injection and application startup
ClientController	Coordinates client operations
ETMSystemContext	Database configuration and EF Core mappings
NuGet Packages
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
Spectre.Console
BCrypt.Net-Next
Future Improvements
Move connection strings to configuration files
Add unit tests
Add integration tests
Implement logging
Add database migration scripts
Improve exception handling
Enhance validation
Screenshots
Add screenshots of:

Login Screen
Main Menu
Client Management
Travel Management
Contract Management
Contributing
Contributions are welcome.

Fork the repository
Create a feature branch
Commit changes
Submit a pull request
License
This project is licensed under the MIT License.

See the LICENSE file for details.

