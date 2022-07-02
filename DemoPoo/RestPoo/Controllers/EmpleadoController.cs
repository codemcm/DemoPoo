using Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestPoo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {

        [HttpGet("/SalarioDiario")]
        public IActionResult GetSalarioQuincenal(int SalarioDiario)
        {
            Empleado empleado = new Empleado();
            empleado.SalarioDiario = SalarioDiario;

            return Ok(empleado.CalcularSalario());

        }
        [HttpGet("/{Nombre}/{Correo}")]

        public IActionResult MostrarInfo(string Nombre ,string Correo)
        {
            Empleado empleado = new Empleado();
            empleado.Nombre = Nombre;
            empleado.Correo = Correo;
            return Ok(empleado.MostrarDatos());

        }
    }
}
