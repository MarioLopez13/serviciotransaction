using Microsoft.EntityFrameworkCore;
using TransactionService.Core.Entities;

namespace TransactionService.Infrastructure.Persistence;

public class ProyectContext : DbContext
{
    public ProyectContext(DbContextOptions<ProyectContext> options) : base(options) { }

    public DbSet<Transaction> Transactions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Transaction>(b =>
        {
            b.ToTable("Transaccion");

            b.HasKey(e => e.Id_Transaccion);

            b.Property(e => e.Id_Transaccion)
                .HasColumnName("Id_Transaccion")
                .HasPrecision(10, 0); // Important: Precision for numeric PK


            b.Property(e => e.Fecha_Transaccion)
                .HasColumnName("Fecha_Transaccion");

            b.Property(e => e.Monto)
                .HasColumnName("Monto")
                .HasPrecision(10, 2);

            b.Property(e => e.Estado)
                .HasColumnName("Estado");

            b.Property(e => e.Id_OrigenCli)
                .HasColumnName("Id_OrigenCli")
                .HasPrecision(10, 0);

            b.Property(e => e.Id_Cliente)
                .HasColumnName("Id_Cliente")
                .HasPrecision(10, 0);

            // ... other mappings (if any)
        });

        // ... other entity configurations (if any)
    }
}
////d