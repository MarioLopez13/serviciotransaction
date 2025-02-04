﻿using TransactionService.Core.Entities;

namespace TransactionService.Core.Ports;

public interface ITransactionService
{
    Task<Transaction> CreateTransaction(Transaction transaction);
    Task<Transaction?> GetTransactionById(decimal id); // Changed to decimal
    Task UpdateTransaction(Transaction transaction);
}