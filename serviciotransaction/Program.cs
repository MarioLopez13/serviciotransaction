using Microsoft.EntityFrameworkCore;
using TransactionService.Infrastructure.Persistence;
using TransactionService.Core.Ports; // Añadido
using TransactionService.Core.Services; // Añadido
using Swashbuckle.AspNetCore; // Añadido

var builder = WebApplication.CreateBuilder(args);

// Configuración de la base de datos
builder.Services.AddDbContext<ProyectContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionProyecto")));

// Inyección de dependencias
builder.Services.AddTransient<ITransactionService, TransactionService.Core.Services.TransactionService>();

builder.Services.AddTransient<ITransactionRepository, SqlTransactionRepository>();

// Servicios para API
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // Paquete Swashbuckle.AspNetCore instalado

var app = builder.Build();

// Configuración del pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Namespace Swashbuckle.AspNetCore añadido
    app.UseSwaggerUI(); // Namespace Swashbuckle.AspNetCore añadido
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();