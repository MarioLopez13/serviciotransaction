using Microsoft.EntityFrameworkCore;
using TransactionService.Infrastructure.Persistence;
using TransactionService.Core.Ports; // A�adido
using TransactionService.Core.Services; // A�adido
using Swashbuckle.AspNetCore; // A�adido

var builder = WebApplication.CreateBuilder(args);

// Configuraci�n de la base de datos
builder.Services.AddDbContext<ProyectContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionProyecto")));

// Inyecci�n de dependencias
builder.Services.AddTransient<ITransactionService, TransactionService.Core.Services.TransactionService>();

builder.Services.AddTransient<ITransactionRepository, SqlTransactionRepository>();

// Servicios para API
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // Paquete Swashbuckle.AspNetCore instalado

var app = builder.Build();

// Configuraci�n del pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Namespace Swashbuckle.AspNetCore a�adido
    app.UseSwaggerUI(); // Namespace Swashbuckle.AspNetCore a�adido
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();