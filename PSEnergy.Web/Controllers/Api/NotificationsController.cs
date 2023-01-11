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
    public class NotificationsController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public NotificationsController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]

        public async Task<IActionResult> GetNotifications()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            System.Collections.Generic.List<Notification> notifications = await _dataContext.PSNotificaciones
                .Where (o => o.FECHACARGA.ToString().Substring(0,4).Equals(DateTime.Now.Year.ToString()))
            .OrderBy(o => o.IDNOTFICACION)
            .ToListAsync();
            return Ok(notifications);
        }
    }
}