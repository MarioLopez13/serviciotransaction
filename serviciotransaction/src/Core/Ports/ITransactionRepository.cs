using TransactionService.Core.Entities;

namespace TransactionService.Core.Ports;

public interface ITransactionRepository
{
    Task<Transaction> CreateTransaction(Transaction transaction);
    Task<Transaction?> GetTransactionById(decimal id); // Changed to decimal
}