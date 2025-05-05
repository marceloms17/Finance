📄 Available in: [English](README.en.md) | [Português](README.md)

# 💼 Technical Challenge - Guide Investimentos

This project was developed as part of a technical challenge for a Senior Software Engineer position at Guide Investimentos. The goal was to demonstrate backend development skills using .NET, microservice architecture, Docker orchestration, and software engineering best practices.

---

## 🚀 Technologies Used

- .NET 6 / ASP.NET Core Web API
- C#
- Entity Framework Core
- Docker & Docker Compose
- EF Core Migrations
- Clean Architecture and Repository Pattern

---

## 🧱 Project Structure

```
AssetVariations/
├── docker-compose.yml
├── src/
│   ├── Asset.Services.Variation.Data/
│   │   ├── Context/ (DbContext)
│   │   ├── Entities, Models
│   │   ├── Interfaces, Repository
│   │   └── Migrations/
│   └── Asset.Variation.Api/
│       ├── Controllers
│       ├── Program.cs / appsettings.json
```

---

## 🧪 Features

- RESTful API for managing financial asset variations
- Data persistence via EF Core
- Clear separation of concerns (Data / API)
- Environment-based configuration
- Docker-based orchestration

---

## ▶️ How to Run

1. Clone the repository:
```bash
git clone https://github.com/your-user/Finance.git
```

2. Run using Docker:
```bash
docker-compose up --build
```

3. Access the API at:
```
http://localhost:5000/swagger
```

---

## 👤 Author

Marcelo Morais dos Santos  
📧 marceloms17@gmail.com  
🔗 [LinkedIn](https://www.linkedin.com/in/marcelo-morais-61584146)
