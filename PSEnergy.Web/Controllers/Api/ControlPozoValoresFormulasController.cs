using Microsoft.AspNetCore.Mvc;
using PSEnergy.Web.Data;
using PSEnergy.Web.Data.Entities;
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

        [HttpPost]
        public async Task<ActionResult<ControlPozoValoresFormula>> PostControlPozoValoresFormula(ControlPozoValoresFormula request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _dataContext.ControlPozoValoresFormulas.Add(request);
            await _dataContext.SaveChangesAsync();
            return Ok(request);
        }
    }
}