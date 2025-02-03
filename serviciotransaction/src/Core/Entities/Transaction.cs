namespace TransactionService.Core.Entities;

public class Transaction
{
    public int Id_Transaccion { get; set; } // Clave primaria (corregido)
    public DateTime Fecha { get; set; }
    public decimal Monto { get; set; }
    public string Estado { get; set; }
    public int IdCliente { get; set; }
}