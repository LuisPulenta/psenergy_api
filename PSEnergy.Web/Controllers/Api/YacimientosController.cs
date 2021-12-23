using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PSEnergy.Web.Data;
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

        [HttpPost]
        [Route("GetYacimientos/{Area}")]
        public async Task<IActionResult> GetYacimientos(AreaRequest area)
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