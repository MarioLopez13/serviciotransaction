using Microsoft.AspNetCore.Mvc;
using TransactionService.Core.Ports;
using TransactionService.Core.Entities;

namespace TransactionService.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TransactionsController : ControllerBase
{
    private readonly ITransactionService _service;

    public TransactionsController(ITransactionService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> CreateTransaction([FromBody] Transaction transaction)
    {
        var newTransaction = await _service.CreateTransaction(transaction);
        return CreatedAtAction(nameof(GetTransactionById), new { id = newTransaction.Id_Transaccion }, newTransaction); // Usar Id_Transaccion
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetTransactionById(int id)
    {
        var transaction = await _service.GetTransactionById(id);
        return transaction == null ? NotFound() : Ok(transaction);
    }
}