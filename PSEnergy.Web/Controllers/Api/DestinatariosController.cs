using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PSEnergy.Web.Data;
using PSEnergy.Web.Data.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace PSEnergy.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinatariosController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public DestinatariosController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpPost]
        [Route("GetDestinos/{IDUser}")]
        public async Task<IActionResult> GetDestinos(int IDUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var destinos = await _dataContext.PSDestinatarios
           .Where(o => (o.IDUSER == IDUser))

           .OrderBy(o => o.IDNOTIFICACION)
           .ToListAsync();


            if (destinos == null)
            {
                return BadRequest("No hay Destinos.");
            }
            return Ok(destinos);
        }

    }
}