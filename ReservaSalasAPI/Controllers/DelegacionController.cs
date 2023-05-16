using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ReservaSalasAPIAplicacion.Dto;
using ReservaSalasAPIAplicacion.Servicios;
using ReservaSalasAPIDominio.Servicios;

namespace ReservaSalasAPI.Controllers
{
    [ApiController]

    //[Route("api/delegaciones")]

    public class DelegacionController : ControllerBase
    {
        private readonly IDelegacionServicio _delegacionServicio;

        public DelegacionController(IDelegacionServicio delegacionServicio)
        {
            _delegacionServicio = delegacionServicio;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<DelegacionDto>> Get(int id)

        {
            var delegacion = await _delegacionServicio.GetDelegacionByIdAsync(id);

            if (delegacion == null)
            {
                return NotFound();
            }

            return Ok(delegacion);

        }
    }
}
