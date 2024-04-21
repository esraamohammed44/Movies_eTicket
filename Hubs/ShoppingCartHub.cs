using Microsoft.AspNetCore.SignalR;

namespace eTickets.Hubs
{
    public class ShoppingCartHub:Hub
    {
        public async Task UpdateShoppingCart()
        {
            // Notify clients about the shopping cart update
            await Clients.All.SendAsync("ReceiveShoppingCartUpdate");
        }
    }
}
