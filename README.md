# MyFirstBlazorApp

A sample Blazor application with a layered architecture using **SSDT** for database management, **Dapper** for data access, and **WebAssembly** for client-side UI.

---

## 📂 Project Structure

| Project       | Purpose                                   | References / Packages |
|---------------|-------------------------------------------|------------------------|
| **ResturantDb** | Database project using **SSDT** (SQL Server Data Tools) | – |
| **DataLibrary** | Data access layer using **Dapper** and SQL Client | - [Dapper](https://www.nuget.org/packages/Dapper)<br>- [Microsoft.Data.SqlClient](https://www.nuget.org/packages/Microsoft.Data.SqlClient) |
| **API**        | REST API exposing CRUD operations for Restaurant data | References **DataLibrary** |
| **BlazorServer** | Server-side Blazor app consuming API and DataLibrary | References **DataLibrary** |
| **BlazorClient** | WebAssembly Blazor app consuming API via HttpClient | - [Microsoft.AspNetCore.Blazor.HttpClient](https://www.nuget.org/packages/Microsoft.AspNetCore.Blazor.HttpClient) |

---

## ⚙️ Architecture Overview

- **Database Layer (ResturantDb)**  
  - Managed via **SSDT** project.  
  - Schema-first approach, no Entity Framework.  

- **Data Access Layer (DataLibrary)**  
  - Uses **Dapper** for lightweight ORM mapping.  
  - SQL queries executed via **Microsoft.Data.SqlClient**.  

- **API Layer (API)**  
  - Provides REST endpoints for CRUD operations.  
  - Acts as the bridge between Blazor apps and the database.  

- **UI Layer**  
  - **BlazorServer**: Server-side rendering with direct access to DataLibrary.  
  - **BlazorClient**: WebAssembly app consuming API endpoints using HttpClient.  

---

## 🚀 Getting Started

1. **Clone the repository**
   ```bash
   git clone https://github.com/SSRout/MyFirstBlazorApp.git
