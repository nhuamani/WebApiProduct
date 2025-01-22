# App en .Net Core 9 Web API y Angular 19

## Backend

Instalación de paquetes por NuGet Package Manager

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.EntityFrameworkCore.Design 
- Scalar.AspNetCore 2.0.2

### Migración

```bash
# realizar migración
Add-Migration Initial

# aplicar migración a la DB
Update-Database
```

### Dev
Swagger: https://localhost:7191/openapi/v1.json
Scalar: https://localhost:7191/scalar/v1
