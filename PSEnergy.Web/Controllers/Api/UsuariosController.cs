using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PSEnergy.Web.Data;
using PSEnergy.Web.Data.Entities;
using System.Threading.Tasks;

namespace PSEnergy.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public UsuariosController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]

        public async Task<IActionResult> GetUsuarios()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            System.Collections.Generic.List<Usuario> usuarios = await _dataContext.SubContratistasUsrWebs
           .ToListAsync();
            return Ok(usuarios);
        }
    }
}