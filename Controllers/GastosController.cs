using ExpenseTracker.Models;
using ExpenseTracker.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers;

[ApiController]
[Route("api/gastos")]
public class GastosController : ControllerBase
{
    private static List<Gasto> gastos = new List<Gasto>();

    [HttpPost]
    public ActionResult<Gasto> RegistrarGasto(CrearGastoDto dto)
    {
        var gasto = new Gasto
        {
            Id = Guid.NewGuid(),
            Descripcion = dto.Descripcion,
            Valor = dto.Valor,
            Fecha = dto.Fecha,
            Categoria = dto.Categoria
        };

        gastos.Add(gasto);

        return StatusCode(201, gasto);
    }

    [HttpGet]
    public ActionResult<List<Gasto>> ListarGastos()
    {
        return Ok(gastos);
    }
}
