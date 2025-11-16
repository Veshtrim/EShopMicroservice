<h1>EShopMicroservice</h1>

<p><strong>.NET 8</strong> · <strong>Clean Architecture</strong> · <strong>Microservices</strong></p>

<p>A modern microservices-based e-commerce backend built with .NET 8, Clean Architecture and Docker.</p>

<h2>Overview</h2>
<p>This project implements a distributed e-commerce backend composed of independent services for core domains such as Ordering, Catalog, Basket, Discount, and Identity. Each service follows Clean Architecture, DDD, and CQRS principles.</p>

<h2>Architecture</h2>

<pre>
+---------------------------------------------------------+
|                   API Gateway                           |
+--------------------+-------------------+----------------+
| Catalog Service    | Basket Service    | Discount gRPC  |
| (REST API)         | (Redis Cache)     | (Microservice) |
+--------------------+-------------------+----------------+
| Ordering Service   |  Event Bus      |
| (CQRS, MediatR)    |  (RabbitMQ)     |
+---------------------------------------------------------+
| Infrastructure: EF Core · PostgreSQL · Docker · .NET 8 |
+---------------------------------------------------------+
</pre>

<h2>Service Structure</h2>
<ul>
  <li>src/Services/Ordering/</li>
  <li>src/Services/Catalog/</li>
  <li>src/Services/Basket/</li>
  <li>src/Services/Discount.Grpc/</li>
</ul>

<h2>Tech Stack</h2>
<ul>
  <li><strong>Backend:</strong> .NET 8 · ASP.NET Core Web API</li>
  <li><strong>Architecture:</strong> DDD · CQRS · MediatR · Clean Architecture</li>
  <li><strong>Messaging:</strong> RabbitMQ (planned)</li>
  <li><strong>Database:</strong> PostgreSQL / SQL Server · EF Core</li>
  <li><strong>Containerization:</strong> Docker · Docker Compose</li>
  <li><strong>Deployment:</strong> Kubernetes (future)</li>
  <li><strong>Dev Tools:</strong> Mapster · Serilog · Swagger</li>
</ul>

<h2>Getting Started</h2>

<h3>Prerequisites</h3>
<ul>
  <li>.NET SDK 8.0+</li>
  <li>Docker Desktop</li>
</ul>

<h3>Setup and Run</h3>

<pre><code># Clone
git clone https://github.com/Veshtrim/EShopMicroservice.git
cd EShopMicroservice

# Build
dotnet build

# Run a service
cd src/Services/Ordering/Ordering.API
dotnet run

# Swagger:
http://localhost:5000/swagger
</code></pre>

<h3>Run with Docker</h3>
<pre><code>docker-compose up --build
</code></pre>

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
}
</code></pre>

<h2>Future Roadmap</h2>
<ul>
  <li>Kubernetes manifests</li>
  <li>Serilog + Seq centralized logging</li>
  <li>Prometheus + Grafana monitoring</li>
  <li>Identity service with JWT</li>
  <li>API Gateway (Ocelot or YARP)</li>
</ul>

<h2>Testing</h2>
<pre><code>dotnet test
</code></pre>

<h2>Development Principles</h2>
<ul>
  <li>Clean Architecture: Application · Domain · Infrastructure · API</li>
  <li>CQRS for command/query separation</li>
  <li>Database per service</li>
  <li>Modular and independently deployable</li>
</ul>

<h2>Contributing</h2>
<ol>
  <li>Fork the project</li>
  <li>Create a feature branch</li>
  <li>Commit changes</li>
  <li>Open a pull request</li>
</ol>


<h2>Author</h2>
<p>Veshtrim Mulaku — .NET Developer & Microservice Architect</p>
