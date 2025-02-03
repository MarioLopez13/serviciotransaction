using TransactionService.Core.Ports;
using TransactionService.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace TransactionService.Infrastructure.Persistence;

public class SqlTransactionRepository : ITransactionRepository
{
    private readonly ProyectContext _context;

    public SqlTransactionRepository(ProyectContext context)
    {
        _context = context;
    }

    public async Task<Transaction> CreateTransaction(Transaction transaction)
    {
        _context.Transactions.Add(transaction);
        await _context.SaveChangesAsync();
        return transaction;
    }

    public async Task<Transaction?> GetTransactionById(int id)
    {
        return await _context.Transactions.FindAsync(id);
    }
}