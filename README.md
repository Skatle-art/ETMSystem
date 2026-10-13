# Employee Transport Management System (ETMSystem)

A .NET 10 console-based application for managing employee transport operations, including clients, drivers, travel records, contracts, and user accounts.

**Developed by Katleho Molefe**

---

## Overview

The Employee Transport Management System (ETMSystem) streamlines the administration of employee transportation services through a layered architecture that separates presentation, business logic, and data access concerns.

---

## Features

- User registration and authentication
- Client management
- Travel management
- Contract management
- Driver management
- Password hashing with BCrypt
- SQL Server database integration
- Dependency Injection
- Repository Pattern
- Layered Architecture

---

## Architecture

```text
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
```

---

## Project Structure

```text
ETMSystem
│
├── Controller
├── Data
├── Models
├── Repository
├── Service
├── View
└── Program.cs
```

---

## Technology Stack

- C#
- .NET 10
- Entity Framework Core
- SQL Server
- Spectre.Console
- BCrypt.Net-Next
- Microsoft Dependency Injection

---

## Database Configuration

The application uses SQL Server through Entity Framework Core.

For security and portability, connection strings should be stored in configuration files rather than hardcoded in source code.

Example:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "YOUR_CONNECTION_STRING"
  }
}
```

---

## Prerequisites

Before running the application, install:

- .NET 10 SDK
- SQL Server or SQL Server LocalDB
- Visual Studio 2022 or later

---

## Running the Application

### Visual Studio

```text
1. Open ETMSystem.slnx
2. Build Solution
3. Press F5
```

### Command Line

```bash
dotnet restore
dotnet build
dotnet run
```

---

## Main Components

| Component | Purpose |
|------------|-----------|
| Program.cs | Application startup and dependency injection |
| Controller | Handles user interactions |
| Service | Business logic |
| Repository | Data access operations |
| Data | EF Core DbContext and database configuration |
| View | Console UI built with Spectre.Console |

---

## NuGet Packages

```text
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
Spectre.Console
BCrypt.Net-Next
```

---

## Future Improvements

- Unit testing
- Integration testing
- Enhanced exception handling
- Improved validation
- Logging support
- Configuration-based connection strings
- Database migrations

---

## Screenshots

### Login Screen

_Add screenshot here_

### Main Menu

_Add screenshot here_

### Client Management

_Add screenshot here_

---

## Developer

**Katleho Molefe**

Final-Year BCom Information Systems and Technology Student  
University of KwaZulu-Natal

- GitHub: https://github.com/Skatle-art
- LinkedIn: Add your LinkedIn profile link here

---


