using FuelTrack.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace FuelTrack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VeiculosController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VeiculoDTO> GetAll()
        {
          
        }

        [HttpGet]
        public VeiculoDTO GetById()
        {

        }
    }
}
