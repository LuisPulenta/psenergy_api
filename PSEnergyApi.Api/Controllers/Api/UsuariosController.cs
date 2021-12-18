using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PSEnergyApi.Api.Data;
using PSEnergyApi.Web.Data.Entities;
using System.Threading.Tasks;

namespace PSEnergyApi.Web.Controllers.API
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

            System.Collections.Generic.List<Usuario> usuarios = await _dataContext.Usuarios
           .ToListAsync();
            return Ok(usuarios);
        }
    }
}