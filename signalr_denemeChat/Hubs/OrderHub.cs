using Microsoft.AspNetCore.SignalR;

namespace signalr_denemeChat.Hubs
{
    public class OrderHub: Hub
    {
        public override Task OnConnectedAsync()
        {
            //get conntection Id Context.ConnectionId;

            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            return base.OnDisconnectedAsync(exception);
        }
    }
}
