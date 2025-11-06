<h1 align="center">🛍️ EShopMicroservice</h1>

<p align="center">
  <strong>Modern microservices-based e-commerce backend built with .NET 8, Clean Architecture, and Docker.</strong><br />
  Event-driven, modular, and scalable — powered by <b>RabbitMQ</b> (coming soon) and <b>Kubernetes</b> (planned).
</p>

<p align="center">
  <a href="https://dotnet.microsoft.com/en-us/"><img src="https://img.shields.io/badge/.NET-8.0-blueviolet?logo=dotnet&logoColor=white" /></a>
  <a href="#"><img src="https://img.shields.io/badge/Architecture-Microservices-green" /></a>
  <a href="#"><img src="https://img.shields.io/badge/Messaging-RabbitMQ-orange?logo=rabbitmq" /></a>
  <a href="#"><img src="https://img.shields.io/badge/Orchestration-Kubernetes-lightblue?logo=kubernetes" /></a>
  <a href="./LICENSE"><img src="https://img.shields.io/badge/License-MIT-lightgrey" /></a>
</p>

## 🧭 Overview

`EShopMicroservice` is a distributed e-commerce backend built for scalability, modularity, and cloud readiness.
Each core domain — **Ordering**, **Catalog**, **Basket**, **Discount**, and **Identity** — is developed as an independent microservice following **Clean Architecture**, **CQRS**, and **DDD** principles.

> 📨 **RabbitMQ** will power inter-service communication (event-driven messaging), and **Kubernetes** integration is planned for orchestration and production scalability.

---

## 🎗️ Architecture

```
+---------------------------------------------------------+
|                   API Gateway (planned)                 |
+--------------------+-------------------+----------------+
| Catalog Service    | Basket Service    | Discount gRPC  |
| (REST API)         | (Redis Cache)     | (Microservice) |
+--------------------+-------------------+----------------+
| Ordering Service   | Identity Service  | Event Bus (RabbitMQ) |
| (CQRS, MediatR)    | (JWT Auth)        | → Async Messaging     |
+---------------------------------------------------------+
| Infrastructure: EF Core · PostgreSQL · Docker · .NET 8  |
+---------------------------------------------------------+
```

Each service is containerized, independently deployable, and follows a consistent layered structure.

---

## 🧬 Service Structure

```
src/
└── Services/
    ├── Ordering/
    │   ├── Ordering.API
    │   ├── Ordering.Application
    │   ├── Ordering.Domain
    │   └── Ordering.Infrastructure
    ├── Catalog/
    ├── Basket/
    └── Discount.Grpc/
```

---

## ⚙️ Tech Stack

| Category              | Technologies                                    |
| --------------------- | ----------------------------------------------- |
| **Backend**           | .NET 8 · ASP.NET Core Web API                   |
| **Architecture**      | DDD · CQRS · MediatR · Clean Architecture       |
| **Messaging**         | RabbitMQ *(coming soon)*                        |
| **Database**          | PostgreSQL / SQL Server · EF Core               |
| **Containerization**  | Docker · Docker Compose                         |
| **Planned Additions** | Kubernetes · API Gateway · Prometheus + Grafana |
| **Dev Tools**         | Mapster · Serilog · Swagger / OpenAPI           |

---

## 🚀 Getting Started

### 🦬 Prerequisites

* [.NET SDK 8.0+](https://dotnet.microsoft.com/)
* [Docker Desktop](https://www.docker.com/)
* *(Optional)* RabbitMQ – will be available via Docker Compose

### 🛠️ Setup & Run

```bash
# Clone the repository
git clone https://github.com/Veshtrim/EShopMicroservice.git
cd EShopMicroservice

# Build the solution
dotnet build

# Run a specific service
cd src/Services/Ordering/Ordering.API
dotnet run
```

Access Swagger UI:
🔗 [http://localhost:5000/swagger](http://localhost:5000/swagger)

---

## 🐳 Running with Docker

```bash
docker-compose up --build
```

> 🟠 Docker Compose will soon include RabbitMQ, PostgreSQL, and all core services.
> 🦬 Kubernetes manifests will be added later for container orchestration and deployment in production.

---

## ⚙️ Configuration Example

```json
{
  "ConnectionStrings": {
    "OrderingDb": "Host=localhost;Database=OrderingDb;Username=postgres;Password=postgres"
  },
  "RabbitMQ": {
    "Host": "localhost",
    "UserName": "guest",
    "Password": "guest"
  }
}
```

---

## 🧠 Future Roadmap

* [ ] Implement **RabbitMQ** event-driven communication
* [ ] Add **Kubernetes (K8s)** support
* [ ] Centralized logging (**Serilog + Seq**)
* [ ] Monitoring with **Prometheus + Grafana**
* [ ] Identity service with **JWT authentication**
* [ ] API Gateway integration (**Ocelot / YARP**)

---

## 🧪 Testing

* Unit and integration testing via **xUnit** and **Testcontainers**

```bash
dotnet test
```

---

## 🧪 Development Principles

* Clean Architecture: Application · Domain · Infrastructure · API
* CQRS for command/query separation
* Database per service for isolation
* Modular, testable, and independently deployable design

---

## 🤝 Contributing

Contributions are welcome!

1. Fork the repository
2. Create a feature branch: `feature/your-feature`
3. Run tests and ensure CI passes
4. Submit a pull request with a clear description

---

## 📄 License

Licensed under the **MIT License** — see the [LICENSE](./LICENSE) file.

---

## 👤 Author

**Veshtrim Mulaku**
🔗 [GitHub](https://github.com/Veshtrim)  • 💡 .NET Developer | System Architect | Microservice Enthusiast

> Building scalable systems with clean design, asynchronous communication, and cloud-native architecture.







