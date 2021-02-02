using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_ASP.NET.SignalR.Hubs
{
    public class Counter : Hub
    {
        private static int counter = 0;

        public override async Task OnConnectedAsync()
        {
            counter++;
            await Clients.All.SendAsync("UserCount", counter);
        }

        public override async Task OnDisconnectedAsync(Exception ex)
        {
            counter--;
            await Clients.All.SendAsync("UserCount", counter);
        }
    }
}
