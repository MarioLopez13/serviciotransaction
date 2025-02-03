using TransactionService.Core.Entities;

namespace TransactionService.Core.Ports;

public interface ITransactionService
{
    Task<Transaction> CreateTransaction(Transaction transaction);
    Task<Transaction?> GetTransactionById(int id); // Añadido el método GetTransactionById
}