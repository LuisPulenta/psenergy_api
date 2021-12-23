using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PSEnergy.Web.Data;
using PSEnergy.Web.Data.Entities;
using System.Threading.Tasks;

namespace PSEnergy.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreasController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public AreasController(DataContext dataContext)
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

            System.Collections.Generic.List<Area> areas = await _dataContext.Areas
           .ToListAsync();
            return Ok(areas);
        }
    }
}