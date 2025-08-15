# User Management API – TechHive Solutions

An ASP.NET Core Web API designed for managing users with robust middleware for logging, error handling, and token-based authentication—built to meet TechHive Solutions' corporate compliance standards.

---

## Features

- Full CRUD operations for user entities
- Middleware for:
  - Token-based authentication
  - Request/response logging
  - Global error handling
- Modular and scalable architecture
- Easy integration with external services

---

## Middleware Components

### ErrorHandlingMiddleware
- Catches unhandled exceptions
- Returns consistent JSON error responses

## Project Structure

UserManagementAPI/

├── Controllers/

│   └── UsersController.cs

│

├── Middleware/

│   ├── ErrorHandlingMiddleware.cs

│   ├── TokenAuthenticationMiddleware.cs

│   └── LoggingMiddleware.cs

│

├── Models/

│   └── User.cs

│

├── Services/

│   └── UserService.cs

│

├── Program.cs

├── Startup.cs  (optional, if using Startup-based configuration)

├── appsettings.json

├── README.md

└── UserManagementAPI.csproj

