using System.Threading.Tasks;
using chat.Models;
using Microsoft.AspNetCore.SignalR;

namespace chat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(ChatMessage message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}