using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PSEnergy.Web.Data;
using PSEnergy.Web.Data.Entities;
using System;
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

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuario(string id, Usuario request)
        {
            if (id != request.USRLOGIN)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Usuario usuario = await _dataContext.SubContratistasUsrWebs.FindAsync(request.USRLOGIN);
            if (usuario == null)
            {
                return BadRequest("El usuario no existe.");
            }
            usuario.USRCONTRASENA = request.USRCONTRASENA;

            try
            {
                _dataContext.SubContratistasUsrWebs.Update(usuario);
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