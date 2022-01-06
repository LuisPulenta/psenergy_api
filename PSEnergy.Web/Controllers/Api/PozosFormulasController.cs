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
    public class PozosFormulasController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public PozosFormulasController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]

        public async Task<IActionResult> GetPozosFormulas()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            System.Collections.Generic.List<PozosFormula> pozosFormulas = await _dataContext.PozosFormulas
            .OrderBy(o => o.IDFORMULA)
            .ToListAsync();
            return Ok(pozosFormulas);
        }
    }
}