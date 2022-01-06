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
    public class ControlPozoValoresFormulasController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public ControlPozoValoresFormulasController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]

        public async Task<IActionResult> GetAreas()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            System.Collections.Generic.List<ControlPozoValoresFormula> areas = await _dataContext.ControlPozoValoresFormulas
            .OrderBy(o => o.IDCONTROLFORMULA)
            .ToListAsync();
            return Ok(areas);
        }
    }
}
