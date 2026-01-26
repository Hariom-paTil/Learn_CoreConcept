# 🛠️ Implement CQRS: Part 2 - Project Structure

> **Designing the 4 Layers of Clean Architecture with CQRS**

---

## 🏗️ The 4 Layers of CQRS

We split our application into four distinct circles (layers).

### 1️⃣ Domain Layer
*   **Business rules & entities**
*   **Interfaces (Repository)**
*   ❌ No framework, no database dependencies.

### 2️⃣ Application Layer
*   **CQRS logic**
*   **Commands, Queries, Handlers**
*   **DTOs, MediatR, AutoMapper**
*   ✅ Uses Domain interfaces.

### 3️⃣ Infrastructure Layer
*   **Database & EF Core**
*   **Repository implementations**
*   **External services**

### 4️⃣ Presentation Layer
*   **API / UI**
*   **Controllers & endpoints**
*   ✅ Sends Commands/Queries via **MediatR**.

---

## 🚀 Step-by-Step Guide to Create the Solution

Follow these steps in **Visual Studio Community** to set up the project structure.

### 🔹 Step 1: Open Visual Studio Community
1.  Launch **Visual Studio Community**.
2.  Click **Create a new project**.

### 🔹 Step 2: Create the Presentation Layer (API)
1.  Search for and select **ASP.NET Core Web API**.
2.  Click **Next**.
3.  **Project Configuration**:
    *   **Project Name**: `Employ.Presentation`
4.  Click **Next**.
5.  **Additional Information**:
    *   **Framework**: `.NET 8.0 (Long Term Support)`
    *   **Authentication Type**: `None`
    *   **Enable OpenAPI support**: ✅ Checked
6.  Click **Create**.

> **✅ Purpose of Presentation Layer**
> *   🌐 **Handles**: HTTP requests & responses.
> *   📂 **Contains**: Controllers, API endpoints.
> *   🚀 **Role**: Talks **ONLY** to the Application layer.
> *   ❌ **Restricted**: No database logic, No business rules.

### 🔹 Step 3: Create Domain Layer
1.  Right-click on the **Solution 'Employ.Presentation'** in Solution Explorer.
2.  Select **Add** → **New Project**.
3.  Search for and select **Class Library**.
4.  Click **Next**.
5.  **Project Configuration**:
    *   **Project Name**: `Employ.Domain`
6.  Click **Create**.

> **✅ Purpose of Domain Layer**
> *   🧠 **Handles**: Core business rules.
> *   📂 **Contains**: Entities (e.g., `Employ`), Domain Enums/Exceptions.
> *   🛡️ **Role**: The heart of the system. **Independent** of all other layers.
> *   ❌ **Restricted**: No Entity Framework, No Web API, No external dependencies.

### 🔹 Step 4: Create Application Layer
1.  Right-click on the **Solution**.
2.  Select **Add** → **New Project**.
3.  Select **Class Library**.
4.  Click **Next**.
5.  **Project Configuration**:
    *   **Project Name**: `Employ.Application`
6.  Click **Create**.

> **✅ Purpose of Application Layer**
> *   ⚙️ **Handles**: Application logic & Orchestration (CQRS).
> *   📂 **Contains**: Commands, Queries, DTOs, Interfaces, Validators.
> *   🤝 **Role**: Depends on **Domain** only.

### 🔹 Step 5: Create Infrastructure Layer
1.  Right-click on the **Solution**.
2.  Select **Add** → **New Project**.
3.  Select **Class Library**.
4.  Click **Next**.
5.  **Project Configuration**:
    *   **Project Name**: `Employ.Infrastructure`
6.  Click **Create**.

> **✅ Purpose of Infrastructure Layer**
> *   💾 **Handles**: Data access & External communications.
> *   📂 **Contains**: `DbContext`, Repository Implementations, Email Services.
> *   🔌 **Role**: Implements interfaces defined in the **Application** layer.

---

## 📸 Final Project Structure

It should look like this after you create all the projects:

![Solution Explorer Structure](./images/solution_structure.png)

---

<div align="center">

**🔜 Next Step:** [**Part 3 - Domain Layer Implementation**](./Implement_CQRS_Part_3.md)

</div>
