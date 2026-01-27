# 🛠️ Implement CQRS: Part 4 - Step-by-Step Implementation Flow

> **The exact order to follow when building any feature in CQRS.**

## 🏗️ Implementation Context: `CORS_CleanArchitecture`

## 🥇 STEP-BY-STEP ORDER (COMMAND & QUERY)

### 🧠 STEP 1: Decide the Use Case (NO CODE)

**Ask:**
*   Is this **READ** or **CHANGE**?

**Result:**
*   **READ** → **Query**
*   **CHANGE** → **Command**

📌 **This decides everything**

---

### 🥈 STEP 2: Create DTOs (Input & Output)

📁 **Application layer**

*   **Input DTO** (Command properties)
*   **Output DTO** (Response)

✔️ **Now you know:**
*   What comes **in**
*   What goes **out**

---

### 🥉 STEP 3: Create Command / Query

📁 **Application layer**

*   `CreateUserCommand`
*   `GetAllUserQuery`

❗ **No logic yet — just structure**

---

### 🏅 STEP 4: Create Handler (CORE OF CQRS)

📁 **Application layer**

*   `CreateUserCommandHandler`
*   `GetAllUserQueryHandler`

👉 **This is where flow lives**

**Validate → Process → Save → Return**

📌 **At this point you will realize:**
*   What repositories are needed
*   What services are needed

---

### 🏆 STEP 5: Create Repository Interfaces

📁 **Application layer**

*   `IUserReadRepository`
*   `IUserWriteRepository`

✔️ **Handler depends on interfaces, not EF**

---

### 🔧 STEP 6: Implement Repository

📁 **Infrastructure layer**

*   `UserReadRepository`
*   `UserWriteRepository`

✔️ **EF Core logic goes here**

---

### 🔁 STEP 7: Create AutoMapper Profile

📁 **Application layer**

**Map:**
*   **Command** → **Entity**
*   **Entity** → **DTO**

✔️ **Mapping becomes obvious after handler exists**

---

### 🌐 STEP 8: Create Controller (LAST)

📁 **API layer**

**Only calls:**
```csharp
_mediator.Send(...)
```

❗ **Controller should be thin & boring.**

---

<div align="center">

**🔜 Next Step:** [**Part 5 - Hands-on Coding**](./Implement_CQRS_Part_5.md)

</div>
