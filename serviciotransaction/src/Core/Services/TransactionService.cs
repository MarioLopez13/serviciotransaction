﻿using TransactionService.Core.Ports;
using TransactionService.Core.Entities;

namespace TransactionService.Core.Services;

public class TransactionService : ITransactionService
{
    private readonly ITransactionRepository _repository;

    public TransactionService(ITransactionRepository repository)
    {
        _repository = repository;
    }

    public async Task<Transaction> CreateTransaction(Transaction transaction)
    {
        if (transaction.Monto <= 0)
        {
            throw new ArgumentException("El monto debe ser mayor que cero.");
        }

        return await _repository.CreateTransaction(transaction);
    }

    public async Task<Transaction?> GetTransactionById(decimal id) // Changed to decimal
    {
        return await _repository.GetTransactionById(id);
    }
    public async Task UpdateTransaction(Transaction transaction)
    {
        await _repository.UpdateTransaction(transaction);
    }
}