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
    public class ControlDePozoAlarmasController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public ControlDePozoAlarmasController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]

        public async Task<IActionResult> GetAlarmas()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            System.Collections.Generic.List<ControlDePozoAlarma> alarmas = await _dataContext.ControlDePozoAlarmas
                .Where(o=>o.TAG==0)
            .OrderBy(o => o.BATERIA)
            .ToListAsync();
            return Ok(alarmas);
        }
    }
}