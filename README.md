# Employee Transport Management System (ETMSystem)

A small .NET 10 console/CLI application for managing employee transport data (clients, travels, contracts, drivers, users).
The project uses a layered architecture(Data → Repository → Service → Controller → View) 
and relies on Entity Framework Core for data access and Spectre.Console for console UI components.

## Key features
- Manage clients, client travels, contracts and users
- Simple login/registration flow
- EF Core model-first DbContext for `ETMSystemDB`
- Dependency Injection using `Microsoft.Extensions.DependencyInjection`

## Tech stack
- .NET 10 (net10.0)
- C#
- Entity Framework Core 10 (SqlServer provider)
- Spectre.Console (console UI)
- BCrypt.Net-Next (password hashing)

## Project layout (important folders)
- `Data` — EF Core `ETMSystemContext` (DbSets + SQL Server connection)
- `Models` — domain entities (`Client`, `User`, `Contract`, `Travel`, etc.)
- `Repository` — repository implementations / interfaces
- `Service` — business logic services
- `Controller` — controllers used by the console views (e.g., `ClientController`)
- `View` — console view components (Spectre.Console-based)

## Prerequisites
- .NET 10 SDK installed (dotnet)
- SQL Server / LocalDB available (project currently uses LocalDB by default)
- Visual Studio 2022/2026 or VS Code / CLI

## Configuration / Database
By default the DbContext uses LocalDB with this connection string (see `Data/ETMSystemContext.cs`):
Server=(localdb)\MSSQLLocalDB;Database=ETMSystemDB; Trusted_Connection=True; TrustServerCertificate=True;

- Option A (quick): Ensure LocalDB is available and let the app create/use `ETMSystemDB`.
- Option B (recommended): Move the connection string out of source code and into configuration/environment variables. Update `Data/ETMSystemContext.cs` or refactor to use `IConfiguration` in `Program.cs`.

If you want to use EF migrations:
1. Install the EF tools: __dotnet tool install --global dotnet-ef__ (if not installed)
2. Add a migrations project or run from the project folder:
   - __dotnet ef migrations add InitialCreate__
   - __dotnet ef database update__

(Adjust commands to your environment and ensure the connection string points to a reachable SQL Server instance.)

## Build & Run

Using Visual Studio:
1. Open the solution `ETMSystem.slnx` in Visual Studio.
2. Build the solution (__Build Solution__).
3. Run the app (__Start Debugging__ / press __F5__ or __Ctrl+F5__).

Using the CLI:
1. From the project root:
   - __dotnet restore__
   - __dotnet build__
   - __dotnet run__

## Common entry points
- `Program.cs` registers services and DI, resolves `ClientController`, then displays login and main views.
- `ClientController` orchestrates client CRUD via service interfaces (`ICreateClientService`, `IReadClientService`, etc.).
- `Data/ETMSystemContext.cs` contains EF model configuration and the current connection string.

## Dependencies (from `ETMSystem.csproj`)
- `Microsoft.EntityFrameworkCore` (10.0.x)
- `Microsoft.EntityFrameworkCore.SqlServer`
- `Microsoft.EntityFrameworkCore.Tools`
- `Spectre.Console`
- `BCrypt.Net-Next`

## Notes / TODOs
- Move the hardcoded connection string out of `ETMSystemContext` into configuration.
- Add automated tests (no tests found in the repository).
- Consider adding migration scripts or CI steps to provision the database.
- Improve error handling and input validation in views/services.

## Contributing
- Fork the repository, create a feature branch, add tests, and open a PR.
- Keep changes focused and add/update README or documentation as needed.

## License
Specify a license (e.g., MIT) in `LICENSE` if you intend to make this public.

---

If you want, I can:
- Generate a polished `README.md` file with screenshots or usage examples.
- Extract and list all public commands/views and sample CLI walkthrough.
