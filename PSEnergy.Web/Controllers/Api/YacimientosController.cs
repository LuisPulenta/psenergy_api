using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PSEnergy.Web.Data;
using PSEnergy.Web.Data.Entities;
using PSEnergy.Web.Models.Request;
using System.Linq;
using System.Threading.Tasks;

namespace PSEnergy.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class YacimientosController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public YacimientosController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]

        public async Task<IActionResult> GetYacimientos()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            System.Collections.Generic.List<Yacimiento> yacimientos = await _dataContext.Yacimientos
            .OrderBy(o => o.NOMBREYACIMIENTO)
            .ToListAsync();
            return Ok(yacimientos);
        }


        [HttpPost]
        [Route("GetYacimientosByArea/{Area}")]
        public async Task<IActionResult> GetYacimientosByArea(AreaRequest area)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var yacimientos = await _dataContext.Yacimientos
           .Where(o => (o.AREA== area.Area))
           .OrderBy(o => o.NOMBREYACIMIENTO)
           .ToListAsync();

            if (yacimientos == null)
            {
                return BadRequest("No hay Yacimientos para esta Área.");
            }

            return Ok(yacimientos);
        }
    }
}