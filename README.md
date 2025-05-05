📄 Disponível em: [Português](README.md) | [English](README.en.md)

# 💼 Desafio Técnico - Guide Investimentos

Este projeto foi desenvolvido como parte de um desafio técnico para a vaga de Engenheiro de Software Sênior na Guide Investimentos. O objetivo foi demonstrar habilidades em desenvolvimento backend com .NET, arquitetura de microsserviços, uso de Docker e boas práticas de engenharia de software.

---

## 🚀 Tecnologias Utilizadas

- .NET 6 / ASP.NET Core Web API
- C#
- Entity Framework Core
- Docker e Docker Compose
- Migrations e contexto com EF
- Clean Architecture e Repository Pattern

---

## 🧱 Estrutura do Projeto

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

## 🧪 Funcionalidades

- API REST para registro de variação de ativos financeiros
- Persistência via EF Core
- Separação clara de responsabilidades (Data / API)
- Configurações por ambiente
- Contêineres para orquestração via Docker

---

## ▶️ Como Executar

1. Clonar o repositório:
```bash
git clone https://github.com/seu-usuario/Finance.git
```

2. Rodar com Docker:
```bash
docker-compose up --build
```

3. Acessar via navegador ou Postman:
```
http://localhost:5000/swagger
```

---

## 👤 Autor

Marcelo Morais dos Santos  
📧 marceloms17@gmail.com  
🔗 [LinkedIn](https://www.linkedin.com/in/marcelo-morais-61584146)
