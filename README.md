# 🛒 E-Commerce Backend System  

A backend-focused **E-Commerce System** built with **ASP.NET Core 8 Web API** using **Clean Architecture & Onion Architecture** principles to ensure scalability, maintainability, and separation of concerns.  

## 🚀 Features  

- **Modular Design**: Products and Basket modules with RESTful APIs.  
- **High Performance Basket Storage**: Basket data persisted using **Redis** for fast in-memory access.  
- **Authentication & Authorization**:  
  - ASP.NET Core Identity  
  - JWT Tokens  
  - Role-Based Access Control (Admin / User)  
- **Design Patterns**: Implemented **Repository, Specification, and Unit of Work** to enhance code reusability and testability.  
- **Database**: SQL Server as the primary relational database.  
- **DTO Mapping**: AutoMapper for clean and efficient object mapping.  
- **Caching Strategies**: Optimized performance and reduced database load.  
- **Payment Integration**: Simulated online payment processing functionality.  

## 🏗️ Architecture  

This project follows **Clean Architecture** with **Onion Architecture** principles:  

- **Domain Layer** → Entities, core business rules, and interfaces.  
- **Application Layer** → Business logic, use cases, specifications.  
- **Infrastructure Layer** → Data persistence (EF Core, Redis, SQL Server).  
- **API Layer** → Controllers, endpoints, authentication, and presentation logic.  

┌───────────────────┐
│   Presentation    │  → ASP.NET Core 8 Web API
└────────▲──────────┘
         │
┌────────▼──────────┐
│   Application     │  → Use cases, services, DTOs
└────────▲──────────┘
         │
┌────────▼──────────┐
│     Domain        │  → Entities, business rules
└────────▲──────────┘
         │
┌────────▼──────────┐
│  Infrastructure   │  → EF Core, SQL Server, Redis
└───────────────────┘


## 🛠️ Technologies Used  

- **.NET 8 (ASP.NET Core Web API)**  
- **Entity Framework Core**  
- **SQL Server**  
- **Redis** (for basket persistence)  
- **ASP.NET Core Identity + JWT**  
- **AutoMapper**  
- **Design Patterns**: Repository, Unit of Work, Specification  
- **Clean & Onion Architecture**  

## 📦 Modules  

### 🔹 Products Module  
- Get all products  
- Get product by ID  
- Search & filter products  

### 🔹 Basket Module  
- Get user basket  
- Update basket  
- Delete basket  

### 🔹 Authentication Module  
- Register / Login users  
- JWT token generation  
- Role-based access control  

### 🔹 Payment Module  
- Simulated online payment integration  

## ⚡ Getting Started  

### Prerequisites  
- .NET 8 SDK  
- SQL Server  
- Redis  

