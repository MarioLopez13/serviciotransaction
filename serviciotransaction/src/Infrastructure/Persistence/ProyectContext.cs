using Microsoft.EntityFrameworkCore;
using TransactionService.Core.Entities;

namespace TransactionService.Infrastructure.Persistence;

public class ProyectContext : DbContext
{
    public ProyectContext(DbContextOptions<ProyectContext> options) : base(options) { }

    public DbSet<Transaction> Transactions { get; set; }
}