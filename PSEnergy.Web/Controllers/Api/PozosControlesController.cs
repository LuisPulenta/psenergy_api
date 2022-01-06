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
    public class PozosControlesController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public PozosControlesController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]

        public async Task<IActionResult> GetPozosControles()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            System.Collections.Generic.List<PozosControle> pozosControles = await _dataContext.PozosControles
            .OrderBy(o => o.IDCONTROL)
            .ToListAsync();
            return Ok(pozosControles);
        }
    }
}