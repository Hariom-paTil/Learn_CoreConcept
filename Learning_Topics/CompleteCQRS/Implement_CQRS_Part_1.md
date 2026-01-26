# 🛠️ Implement CQRS: Part 1 - The Problem Statement

> **Objective: Moving from Traditional CRUD to Clean Architecture with CQRS**

---

## 📋 Background

The application manages employee data stored in a SQL Server table.

### 🗄️ Database Schema: `Employ`

```sql
CREATE TABLE Employ (
    Id          INT PRIMARY KEY IDENTITY(1,1),
    Name        NVARCHAR(100),
    Age         INT,
    Department  NVARCHAR(100)
);
```

**Current State:**
Data access is handled in a traditional CRUD style where **read** and **write** operations are mixed together. As the application grows, this approach becomes difficult to maintain, test, and scale.

---

## ❌ The Problem

We need a clean, maintainable, and scalable way to handle read and write operations for the `Employ` table while following **Clean Architecture** principles.

**Main Issues:**
- 🍝 **Spaghetti Code**: Mixing read and write logic in the same services.
- 🔗 **Tight Coupling**: Controllers are tightly bound to business logic and data access.
- 🧪 **Hard to Test**: Difficult to test business logic independently.
- 🤷 **No Separation**: Lack of clear separation of responsibilities.

---

## ✅ Proposed Solution

Implement the **CQRS (Command Query Responsibility Segregation)** pattern using **MediatR** within a **Clean Architecture**.

### 🔑 Key Ideas
1.  **Commands**: Handle write operations (Create, Update, Delete).
2.  **Queries**: Handle read operations (Get, GetAll).
3.  **Single Responsibility**: Each operation (Command/Query) does exactly **one** thing.
4.  **Isolation**: Business logic will be isolated from infrastructure concerns (DB).

---

## 🎯 Scope of Implementation

### 🔎 Read Operations (Queries)
- `GetEmployeeByIdQuery`: Get a single employee details.
- `GetAllEmployeesQuery`: Get a list of all employees.

### ✍️ Write Operations (Commands)
- `CreateEmployeeCommand`: Add a new employee.
- `UpdateEmployeeCommand`: Modify existing details.
- `DeleteEmployeeCommand`: Remove an employee.

---

## 🏗️ Architecture Goals

To ensure a high-quality codebase, we will adhere to these rules:

| Goal | Description |
|------|-------------|
| **Clean Architecture** | Strict layering (Domain, Application, Infrastructure, API). |
| **CQRS + MediatR** | Decoupling the Controller from the Logic using the Mediator pattern. |
| **DTOs** | Never expose internal Domain Entities to the outside world; use Data Transfer Objects. |
| **Generic Repository** | Abstract data access logic to keep the Application layer clean. |
| **Dependency Injection** | Keep the Application layer independent of EF Core implementation. |

---

## 🚀 Expected Outcome

At the end of this implementation:

1.  **Separation**: Read and Write operations are clearly separated.
2.  **MediatR**: Each request is handled through a specific pipeline.
3.  **Maintainability**: Codebase is easier to understand, test, and extend.
4.  **Structure**: The project structure clearly reflects Clean Architecture principles.

---

<div align="center">

**🔜 Next Step:** [**Project Setup & Folder Structure**](./Implement_CQRS_Part_2.md)

</div>
