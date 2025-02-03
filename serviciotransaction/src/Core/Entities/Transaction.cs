using System.ComponentModel.DataAnnotations; // Asegúrate de tener este using

namespace TransactionService.Core.Entities;


public class Transaction
{
    [Key]
    public decimal Id_Transaccion { get; set; } // Changed to decimal

    public DateTime Fecha_Transaccion { get; set; }

    public decimal Monto { get; set; }

    public string Estado { get; set; }

    public decimal Id_OrigenCli { get; set; }

    public decimal Id_Cliente { get; set; }
}