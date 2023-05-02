using Microsoft.AspNetCore.Mvc;
using NewShore.Bussines;
using NewShore.DataAccess;
using NewShoreAir.Domain.Excepciones;

namespace NewShoreAir.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisponibilidadController : ControllerBase
    {
        public IDisponibilidadBussines _disponibilidadBussines;

        public DisponibilidadController(IDisponibilidadBussines disponibilidadBussines)
        {
            _disponibilidadBussines = disponibilidadBussines;
        }

        [HttpGet("DisponibilidadNeta/{SKU}", Name = "DisponibilidadNeta")]
        public async Task<IActionResult> DisponibilidadNeta(string SKU)
        {
            var result = _disponibilidadBussines.UnidadesPorUbicacion(SKU);
           
            return Ok(result);

        }

        [HttpGet("TotalInventarioComprometido/{SKU}", Name = "TotalInventarioComprometido")]
        public async Task<IActionResult> TotalInventarioComprometido(string SKU)
        {
            var result = _disponibilidadBussines.TotalInventarioComprometido(SKU);

            return Ok(result);

        }



        [HttpGet("UnidadesPorUbicacion/{SKU}", Name = "UnidadesPorUbicacion")]
        public async Task<IActionResult> UnidadesPorUbicacion(string SKU)
        {
            var result = _disponibilidadBussines.UnidadesPorUbicacion(SKU);

            return Ok(result);

        }



      

   


    }
}
