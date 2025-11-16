<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <title>EShopMicroservice</title>
  <style>
    body {
      font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, "Helvetica Neue", Arial, sans-serif;
      line-height: 1.6;
      max-width: 800px;
      margin: 2rem auto;
      padding: 0 1rem;
      color: #333;
    }
    h1, h2, h3 {
      color: #222;
    }
    pre {
      background: #f6f8fa;
      padding: 1rem;
      overflow-x: auto;
    }
    code {
      background: #f1f1f1;
      padding: 0.2rem 0.4rem;
      border-radius: 3px;
    }
    a {
      color: #0366d6;
      text-decoration: none;
    }
    a:hover {
      text-decoration: underline;
    }
    .badge {
      display: inline-block;
      margin: 0 0.2rem 0.5rem 0;
      padding: 0.2rem 0.5rem;
      font-size: 0.75rem;
      color: white;
      background: #28a745;
      border-radius: 2px;
    }
    footer {
      margin-top: 4rem;
      font-size: 0.9rem;
      color: #666;
      text-align: center;
    }
  </style>
</head>
<body>

  <h1>EShopMicroservice</h1>

  <p class="badge">.NET 8</p>
  <p class="badge">Clean Architecture</p>
  <p class="badge">Microservices</p>

  <p>A modern microservices-based e-commerce backend built with .NET 8, Clean Architecture and Docker.</p>

  <h2>Overview</h2>
  <p>This project implements a distributed e-commerce backend composed of independent services for core domains like Ordering, Catalog, Basket, Discount and Identity. Each service follows Clean Architecture, DDD and CQRS principles.</p>

  <h2>Architecture</h2>
  <pre>
+---------------------------------------------------------+
|                   API Gateway (planned)                 |
+--------------------+-------------------+----------------+
| Catalog Service    | Basket Service    | Discount gRPC  |
| (REST API)         | (Redis Cache)     | (Microservice) |
+--------------------+-------------------+----------------+
| Ordering Service   | Identity Service  | Event Bus      |
| (CQRS, MediatR)    | (JWT Auth)        | (RabbitMQ)     |
+---------------------------------------------------------+
| Infrastructure: EF Core · PostgreSQL · Docker · .NET 8 |
+---------------------------------------------------------+
  </pre>

  <h2>Service Structure</h2>
  <ul>
    <li><code>src/Services/Ordering/</code></li>
    <li><code>src/Services/Catalog/</code></li>
    <li><code>src/Services/Basket/</code></li>
    <li><code>src/Services/Discount.Grpc/</code></li>
  </ul>

  <h2>Tech Stack</h2>
  <table>
    <tr><th>Category</th><th>Technologies</th></tr>
    <tr><td>Backend</td><td>.NET 8 · ASP.NET Core Web API</td></tr>
    <tr><td>Architecture</td><td>DDD · CQRS · MediatR · Clean Architecture</td></tr>
    <tr><td>Messaging</td><td>RabbitMQ (coming soon)</td></tr>
    <tr><td>Database</td><td>PostgreSQL / SQL Server · EF Core</td></tr>
    <tr><td>Containerization</td><td>Docker · Docker Compose</td></tr>
    <tr><td>Planned Add-Ons</td><td>Kubernetes · API Gateway · Prometheus + Grafana</td></tr>
    <tr><td>Dev Tools</td><td>Mapster · Serilog · Swagger / OpenAPI</td></tr>
  </table>

  <h2>Getting Started</h2>
  <h3>Prerequisites</h3>
  <ul>
    <li>.NET SDK 8.0+</li>
    <li>Docker Desktop</li>
    <li>(Optional) RabbitMQ – will be available via Docker Compose</li>
  </ul>

  <h3>Setup & Run</h3>
  <pre><code># Clone the repository
git clone https://github.com/Veshtrim/EShopMicroservice.git
cd EShopMicroservice

# Build the solution
dotnet build

# Run a specific service
cd src/Services/Ordering/Ordering.API
dotnet run

# Access Swagger UI:
http://localhost:5000/swagger</code></pre>

  <h3>Running with Docker</h3>
  <pre><code>docker-compose up --build</code></pre>
  <p>Docker Compose will soon include RabbitMQ, PostgreSQL, and all core services. Kubernetes manifests will be added later for container orchestration and production deployment.</p>

  <h2>Configuration Example</h2>
  <pre><code>{
  "ConnectionStrings": {
    "OrderingDb": "Host=localhost;Database=OrderingDb;Username=postgres;Password=postgres"
  },
  "RabbitMQ": {
    "Host": "localhost",
    "UserName": "guest",
    "Password": "guest"
  }
}</code></pre>

  <h2>Future Roadmap</h2>
  <ul>
    <li>Implement RabbitMQ event-driven communication</li>
    <li>Add Kubernetes (K8s) support</li>
    <li>Centralised logging (Serilog + Seq)</li>
    <li>Monitoring with Prometheus + Grafana</li>
    <li>Identity service with JWT authentication</li>
    <li>API Gateway integration (Ocelot / YARP)</li>
  </ul>

  <h2>Testing</h2>
  <p>Unit and integration testing via xUnit and Testcontainers</p>
  <pre><code>dotnet test</code></pre>

  <h2>Development Principles</h2>
  <ul>
    <li>Clean Architecture: Application · Domain · Infrastructure · API</li>
    <li>CQRS for command/query separation</li>
    <li>Database per service for isolation</li>
    <li>Modular, testable, independently deployable design</li>
  </ul>

  <h2>Contributing</h2>
  <p>Contributions are welcome!</p>
  <ol>
    <li>Fork the repository</li>
    <li>Create a feature branch: <code>feature/your-feature</code></li>
    <li>Run tests and ensure CI passes</li>
    <li>Submit a pull request with a clear description</li>
  </ol>

  <h2>License</h2>
  <p>This project is licensed under the <a href="LICENSE">MIT License</a>.</p>

  <h2>Author</h2>
  <p>Veshtrim Mulaku • .NET Developer | System Architect | Microservice Enthusiast</p>
  <p>Building scalable systems with clean design, asynchronous communication, and cloud-native architecture.</p>

  <footer>
    © 2025 Veshtrim Mulaku
  </footer>

</body>
</html>
