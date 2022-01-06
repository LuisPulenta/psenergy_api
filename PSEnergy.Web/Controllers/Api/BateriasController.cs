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
    public class BateriasController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public BateriasController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]

        public async Task<IActionResult> GetBaterias()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            System.Collections.Generic.List<Bateria> baterias = await _dataContext.Baterias
            .OrderBy(o => o.DESCRIPCION)
            .ToListAsync();
            return Ok(baterias);
        }
    }
}