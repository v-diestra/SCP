using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SCP.Core.ModelEntity;
using SCP.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SenderController : ControllerBase
    {
        private readonly IHubContext<Notificacion> _hubContext;
        public SenderController(IHubContext<Notificacion> hubContext)
        {
            _hubContext = hubContext;
        }

        [HttpPost]
        public IActionResult SendNoti(Usuario usuario)
        {
            string u = Newtonsoft.Json.JsonConvert.SerializeObject(usuario);
            //Enviao hacia Hub
            _hubContext.Clients.All.SendAsync("enviartodos", u);
            return Ok(new { response = "Enviado Correctamente" });
        }
    }
}
