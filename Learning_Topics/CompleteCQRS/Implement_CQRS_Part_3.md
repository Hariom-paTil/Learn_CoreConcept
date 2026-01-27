# 🛠️ Implement CQRS: Part 3 - Complete Project Structure

> **A detailed view of the final file organization.**

Here is the exact folder and file structure you should aim for in your solution.

```plaintext
CORS_CleanArchitecture
│
├── 📂 CORS.Presentation                     ← Presentation Layer (Web API)
│   ├── 📂 Controllers
│   │   └── 📄 EmployeesController.cs
│   ├── 📄 Program.cs
│   └── 📄 appsettings.json
│
├── 📂 CORS.Domain                           ← Domain Layer
│   └── 📂 Entities
│       └── 📄 Employee.cs
│
├── 📂 CORS.Application                      ← Application Layer
│   ├── 📂 Common
│   │   ├── 📂 Interfaces
│   │   │   └── 📄 IGenericRepository.cs
│   │   └── 📂 Mappings
│   │       └── 📄 EmployeeProfile.cs
│   │
│   ├── 📂 DTOs
│   │   └── 📄 EmployeeDto.cs
│   │
│   ├── 📂 Services
│   │   └── 📄 EmployeeService.cs
│   │
│   └── 📂 Features
│       └── 📂 Employees
│           ├── 📂 Commands
│           │   ├── 📄 CreateEmployeeCommand.cs
│           │   ├── 📄 CreateEmployeeCommandHandler.cs
│           │   ├── 📄 UpdateEmployeeCommand.cs
│           │   ├── 📄 UpdateEmployeeCommandHandler.cs
│           │   ├── 📄 DeleteEmployeeCommand.cs
│           │   └── 📄 DeleteEmployeeCommandHandler.cs
│           │
│           └── 📂 Queries
│               ├── 📄 GetEmployeesQuery.cs
│               ├── 📄 GetEmployeesQueryHandler.cs
│               ├── 📄 GetEmployeeByIdQuery.cs
│               └── 📄 GetEmployeeByIdQueryHandler.cs
│
└── 📂 CORS.Infrastructure                   ← Infrastructure Layer
    ├── 📂 Persistence
    │   └── 📄 AppDbContext.cs
    │
    ├── 📂 Repositories
    │   ├── 📄 GenericRepository.cs
    │   └── 📄 EmployeeRepository.cs         (optional, for custom queries)
    │
    └── 📂 Configurations
        └── 📄 EmployeeConfiguration.cs      (Optional Fluent API for EF Core)
```


---

## 📦 1️⃣ Layer → NuGet Packages Table

| Layer | NuGet Package | Purpose |
|-------|---------------|---------|
| **CORS.API** (Presentation) | `MediatR` | Send Commands/Queries to Application layer |
| | `MediatR.Extensions.Microsoft.DependencyInjection` | DI setup in Program.cs |
| | `AutoMapper` | Map DTO ↔ Domain entities |
| | `AutoMapper.Extensions.Microsoft.DependencyInjection` | DI setup in Program.cs |
| | `Swashbuckle.AspNetCore` | Swagger / OpenAPI docs |
| | `Microsoft.EntityFrameworkCore` | Optional direct EF access (usually not needed) |
| | `Microsoft.EntityFrameworkCore.SqlServer` | Optional if API talks directly to DB |
| **CORS.Domain** | *(None)* | **Keep pure**: Only Entities & Domain logic |
| **CORS.Application** | `MediatR` | Handle Commands & Queries |
| | `AutoMapper` | Map Domain ↔ DTO |
| | `FluentValidation` | Optional: validate DTOs/commands |
| | `System.ComponentModel.Annotations` | Data annotations for DTOs |
| **CORS.Infrastructure** | `Microsoft.EntityFrameworkCore` | DbContext & EF mapping |
| | `Microsoft.EntityFrameworkCore.SqlServer` | SQL Server provider |
| | `Microsoft.EntityFrameworkCore.Tools` | Migrations & scaffolding |
| | `AutoMapper` | Optional mapping in Infra (rare) |

---

## 🧠 CQRS Implementation Formula 
# Every Time Before Implementing or Updating any Feature in the CQRS Architecture, Follow the Formula Below:

### 🔹 Question 1: Does this READ data or CHANGE data?
| Type | Meaning | Result |
| :--- | :----- | :----- |
| **Read** | Only fetch data, no state change | **Query** |
| **Change** | Create / Update / Delete data | **Command** |

### 🔹 Question 2: What data comes FROM the client?
✍️ **Write this in plain text (NO CODE)**

**Example: Register User**
* Email
* Password
* FirstName

👉 **These become Command properties**

### 🔹 Question 3: What do I RETURN to the client?
✍️ **Again, plain text only**

**Example**
* UserId
* Email
* CreatedAt

👉 **This becomes your Response DTO**

### 🔹 Question 4: What steps happen INSIDE the system?
Say this sentence slowly 👇

**Validate → Process → Save → Return**

**Example (Register User)**
1. Validate input
2. Hash password
3. Save user
4. Return response

👉 **This defines Handler logic**

### 🔹 Question 5: Who owns each responsibility?
📌 **THIS TABLE ENDS ALL CONFUSION**

| Responsibility | Goes To |
| :--- | :--- |
| HTTP request / response | Controller |
| Orchestration (flow) | Handler |
| Business rules | Domain / Service |
| Validation | Command / Validator |
| Mapping | Handler |
| Database access | Repository |

---

<div align="center">

**🔜 Next Step:** [**Part 4 - Domain Layer Implementation**](./Implement_CQRS_Part_4.md)

</div>
