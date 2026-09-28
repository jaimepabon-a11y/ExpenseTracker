namespace ExpenseTracker.Models;

public class Gasto
{
    public Guid Id { get; set; }
    public string Descripcion { get; set; } = "";
    public decimal Valor { get; set; }
    public DateTime Fecha { get; set; }
    public string Categoria { get; set; } = "";
}
