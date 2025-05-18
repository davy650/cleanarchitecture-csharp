# Clean Architecture - User Registration API (.NET)

Here is a simple **User Registration API** implemented in **.NET 8**, following the **Clean Architecture** principles by Robert C. Martin (Uncle Bob) that you can use for your projects. It demonstrates separation of concerns, testability, and maintainability. Feel free to use this for your projects or add some cool stuff and share

## 🏗️ Architecture Overview

```
CleanArchitecture/
├── CleanArchitecture.Domain          # Business entities
├── CleanArchitecture.Application     # Use cases and interfaces
├── CleanArchitecture.Infrastructure  # Data access and hashing logic
├── CleanArchitecture                 # ASP.NET Core API layer
```

### ✅ Layer Responsibilities

| Layer              | Responsibilities                                  |
|--------------------|---------------------------------------------------|
| **Domain**         | Enterprise business logic and entities            |
| **Application**    | Application business logic (use cases, interfaces)|
| **Infrastructure** | Implementation of external concerns (DB, hashing) |
| **API**            | API endpoints, DI setup, and HTTP request handling|

---

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/)
- (Optional) [Postman](https://www.postman.com/) or `curl` for API testing

### 📦 NuGet Packages Used

- `Microsoft.EntityFrameworkCore.InMemory`
- `BCrypt.Net-Next`
- `Swashbuckle.AspNetCore` (for Swagger)

### 🔧 Setup Instructions

1. Clone or download the repo:
   ```bash
   git clone https://github.com/davy650/cleanarchitecture-csharp.git
   cd CleanArchitecture/
   ```

2. Restore dependencies:
   ```bash
   dotnet restore
   ```

3. Run the Web API:
   ```bash
   dotnet run --project CleanArchitecture
   ```

4. Navigate to Swagger UI:
   ```
   http://localhost:5000/swagger
   ```

---

## 📮 API Endpoint

### `POST /api/users/register`

Registers a new user.

#### ✅ Request Body

```json
{
  "email": "user@example.com",
  "password": "YourSecurePassword123"
}
```

#### 🔄 Response

- `200 OK` – User registered successfully
- `400 Bad Request` – User already exists or validation failed

---

## 🧪 Coding Rules

- Lets just make things simply simple and very simple :)
- Added something nice? let us know and we'd be happy to include it

---

## 🧪 Testing

Unit and integration test projects can be added in the `CleanArchitecture.Tests` folder using `xUnit`, `Moq`, and `FluentAssertions`.

---

## 📂 Project Highlights

- **Clean separation of layers** using interfaces
- **In-memory EF Core database** for simplicity
- **BCrypt password hashing**
- **Scalable and testable** architecture ready for production enhancements (e.g., migrations, validation, logging, etc.)

---

## 🧰 Upcoming Updates

- Add validation with FluentValidation
- Replace InMemory DB with PostgreSQL
- Add authentication (JWT)
- Add unit/integration test coverage
- Use MediatR for CQRS if scaling is needed

---

## 📄 License

MIT License — free for personal and commercial use.

---

## 👨‍💻 Author

Built with ❤️ by [david.ambuka@gmail.com]