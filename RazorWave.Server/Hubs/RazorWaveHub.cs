using Microsoft.AspNetCore.SignalR;

namespace RazorWave.Server.Hubs;

public class RazorWaveHub : Hub
{
    public async Task SendMessage(string message) => await Clients.All.SendAsync("ReceiveMessage", message);
}
