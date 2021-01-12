using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCP.Hubs
{
    public class Notificacion : Hub
    {
        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }
        public Task NotificarTodos(string msg)
        {
            return Clients.All.SendAsync("aprobarcoti", msg);
        }
    }
}
