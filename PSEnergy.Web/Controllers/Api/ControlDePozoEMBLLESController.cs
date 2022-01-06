using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PSEnergy.Web.Data;
using PSEnergy.Web.Data.Entities;
using System;
using System.Threading.Tasks;

namespace PSEnergy.Web.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControlDePozoEMBLLESController : ControllerBase
    {
        private readonly DataContext _context;
        public ControlDePozoEMBLLESController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<ControlDePozoEMBLLE>> PostControlDePozoEMBLLE(ControlDePozoEMBLLE request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ControlDePozoEMBLLE controlDePozoEMBLLE = await _context.ControlDePozoEMBLLES.FirstOrDefaultAsync(x => (x.Pozo.ToUpper() == request.Pozo) && (x.UserIdInput == request.IdUserImputSoft) && (x.Fecha == request.Fecha));
            if (controlDePozoEMBLLE != null)
            {
                return BadRequest("Ya existe una medición para este pozo en la misma fecha por el mimo Usuario.");
            }

            _context.ControlDePozoEMBLLES.Add(request);
            await _context.SaveChangesAsync();
            return Ok(request);
        }

    }
}