using Microsoft.EntityFrameworkCore;
using TransactionService.Infrastructure.Persistence;
using TransactionService.Core.Ports;
using TransactionService.Core.Services;
using Swashbuckle.AspNetCore;

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
builder.Services.AddSwaggerGen();

// *** CONFIGURACI�N DE CORS ***
// 1. Define una pol�tica de CORS (reemplaza con el origen de tu frontend)
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyCorsPolicy", builder =>
    {
        builder.WithOrigins("http://localhost:5059") // Reemplaza con el origen correcto de tu frontend
                           .AllowAnyMethod() // Permite cualquier m�todo HTTP (GET, POST, PUT, DELETE, etc.)
                           .AllowAnyHeader(); // Permite cualquier encabezado
    });
});


var app = builder.Build();

// Configuraci�n del pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// *** USAR LA POL�TICA DE CORS ***
app.UseCors("MyCorsPolicy"); // Aplica la pol�tica CORS definida anteriormente


app.MapControllers();

app.UseStaticFiles();

// Redirecci�n a la vista (Transacciones.html)
app.MapGet("/", async context =>
{
    context.Response.Redirect("/Swagger"); // Ajusta la ruta si es necesario
});

app.Run();