namespace ExpenseTracker.Models.Dtos;

public class CrearGastoDto
{
    public string Descripcion { get; set; } = "";
    public decimal Valor { get; set; }
    public DateTime Fecha { get; set; }
    public string Categoria { get; set; } = "";
}
