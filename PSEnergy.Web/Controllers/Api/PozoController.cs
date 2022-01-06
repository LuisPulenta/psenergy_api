using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PSEnergy.Web.Data;
using PSEnergy.Web.Data.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PSEnergy.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class PozoController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public PozoController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]

        public async Task<IActionResult> GetPozos()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            System.Collections.Generic.List<Pozo> pozos = await _dataContext.Pozo
            .OrderBy(o => o.DESCRIPCION)
            .ToListAsync();
            return Ok(pozos);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPozo(string id, Pozo request)
        {
            if (id != request.CODIGOPOZO)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Pozo pozo = await _dataContext.Pozo.FindAsync(request.CODIGOPOZO);
            if (pozo == null)
            {
                return BadRequest("El pozo no existe.");
            }
            pozo.ULTIMALECTURA = DateTime.Now;

            try
            {
                _dataContext.Pozo.Update(pozo);
                await _dataContext.SaveChangesAsync();
                return NoContent();
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }
    }
}