## 🌐 Live Demo
API deployed via Docker container on Render cloud platform.

Live URL: https://sakshi-apidemo.onrender.com/api/Toy
cd "/Users/Shared/Files From c.localized/Python313/tcl/tk8.6/demos/APIDemo"
<img width="1470" height="814" alt="Screenshot 2026-03-30 at 4 23 44 PM" src="https://github.com/user-attachments/assets/887dcbf8-1e0d-4bb8-9793-6fff1c5ad3bf" />


### Available Endpoints
- GET /api/Toy — retrieve all toys
- GET /api/Toy/{id} — get toy by ID
- POST /api/Toy — create new toy
- PUT /api/Toy/{id} — update toy
- DELETE /api/Toy/{id} — delete toy

# 🚀 .NET 9 Web API Demo

A full Web API demonstration using .NET 9 with CRUD operations (GET, POST, PUT, DELETE), Entity Framework with code-first migrations and SQL Server.

## 📋 Project Overview

This project demonstrates building a complete ASP.NET Core Web API from basics to production-ready implementation:

**🎯 Starting Point**: Explore the default WeatherForecast example to understand model properties (date, temperature, summary), controllers, routes, and HTTP attributes like `[HttpGet]`.

**🔧 Custom Implementation**: Build a sample "Toy" model with properties (id, title, platform, developer, publisher) and controller with initial in-memory storage using static lists.

**⚡ CRUD Operations**: Implement all CRUD action methods (GET all, GET by id, POST, PUT, DELETE) with proper HTTP responses and status codes.

**💾 Database Integration**: Transition from in-memory data to persistent storage by setting up DbContext, configuring SQL Server Express, connection strings in appsettings.json, and installing EF Core packages.

**🔄 Migrations & Production**: Apply EF migrations, seed data, inject DbContext via dependency injection, replace static lists with database access, and make controller actions asynchronous with async/await patterns.

## 🧪 API Testing with Scalar

The API is tested using Scalar interface running on `localhost:7110` with base URL `https://localhost:7118/api/Toy`.

### 📊 Sample API Response
```json
GET /api/Toy - 200 OK
[
  {
    "id": 1,
    "toyName": "Millennium Falcon",
    "brand": "LEGO",
    "model": "75257"
  },
  {
    "id": 2,
    "toyName": "Barbie Dreamhouse",
    "brand": "Mattel",
    "model": "FHY73"
  },
  {
    "id": 3,
    "toyName": "Hot Wheels Track Builder",
    "brand": "Mattel",
    "model": "GGH70"
  }
]
```

### 🛠️ Available Endpoints
- `GET /api/Toy` - Retrieve all toys
- `GET /api/Toy/{id}` - Get toy by ID
- `POST /api/Toy` - Create new toy
- `PUT /api/Toy/{id}` - Update toy
- `DELETE /api/Toy/{id}` - Delete toy

## 🛡️ Key Technologies
- **.NET 9** with ASP.NET Core Web API
- **Entity Framework Core** with SQL Server
- **Code-First Migrations** for database schema
- **Dependency Injection** for DbContext
- **Async/Await** patterns for database operations

## Development Progression
1. **Basic Setup**: WeatherForecast controller exploration
2. **Custom Models**: Toy model with in-memory storage
3. **CRUD Implementation**: Full HTTP operations
4. **Database Migration**: EF Core and SQL Server integration
5. **Production Ready**: Async operations and proper DI
<img width="950" height="473" alt="image" src="https://github.com/user-attachments/assets/5a738263-28c0-4082-bf0c-115a329e3d0f" />
