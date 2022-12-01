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



        [HttpPut("{id}")]
        public async Task<IActionResult> PutPozo(int id, ControlDePozoAlarma request)
        {
            if (id != request.IDALARMA)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ControlDePozoAlarma alarma = await _dataContext.ControlDePozoAlarmas.FindAsync(request.IDALARMA);
            if (alarma == null)
            {
                return BadRequest("La alarma no existe.");
            }
            alarma.IDUSUARIOAPP = request.IDUSUARIOAPP;
            alarma.FECHAEJECUTADA = request.FECHAEJECUTADA;
            alarma.NUEVOIDCONTROL = request.NUEVOIDCONTROL;
            alarma.TAG = 1;

            try
            {
                _dataContext.ControlDePozoAlarmas.Update(alarma);
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