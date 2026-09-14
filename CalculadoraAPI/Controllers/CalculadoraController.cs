using CalculadoraAPI.Models;
using CalculadoraAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalculadoraAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculadoraController : ControllerBase
    {
        private readonly ICalculadoraServicio _calculadoraServicio;

        public CalculadoraController(ICalculadoraServicio calculadoraServicio)
        {
            _calculadoraServicio = calculadoraServicio;
        }

        [HttpPost("sumar")]
        public IActionResult Sumar([FromBody] OperacionRequest request)
        {
            var resultado = _calculadoraServicio.Sumar(request.Number1, request.Number2);
            return Ok(new { resultado });
        }

        [HttpPost("restar")]
        public IActionResult Restar([FromBody] OperacionRequest request)
        {
            var resultado = _calculadoraServicio.Restar(request.Number1, request.Number2);
            return Ok(new { resultado });
        }

        [HttpPost("multiplicar")]
        public IActionResult Multiplicar([FromBody] OperacionRequest request)
        {
            var resultado = _calculadoraServicio.Multiplicar(request.Number1, request.Number2);
            return Ok(new { resultado });
        }

        [HttpPost("dividir")]
        public IActionResult Dividir([FromBody] OperacionRequest request)
        {
            try
            {
                var resultado = _calculadoraServicio.Dividir(request.Number1, request.Number2);
                return Ok(new { resultado });
            }
            catch (DivideByZeroException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
    }
}