
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PSEnergy.Web.Data;
using PSEnergy.Web.Models.Request;
using System.Threading.Tasks;

namespace GenericApp.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public AccountController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpPost]
        [Route("GetUserByEmail")]
        public async Task<IActionResult> GetUser(UsuarioRequest userRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

                var user = await _dataContext.Usuarios.FirstOrDefaultAsync(
                    o => o.Login.ToLower() == userRequest.Email.ToLower() 
                    && o.Contrasena.ToLower() == userRequest.Password.ToLower()
                    && o.PermOS == 1
                    );
                if (user == null)
                {
                    return BadRequest("El Usuario no existe.");
                }
               

                return Ok(user);
            }
        }
    }
