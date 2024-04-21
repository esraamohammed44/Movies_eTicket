using eTickets.Cart;
using eTickets.Hubs;
using eTickets.Models.ViewModel;
using eTickets.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Security.Claims;

namespace eTickets.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly IMovieRepository _moviesRepository;
        private readonly ShoppingCart _shoppingCart;
        private readonly IOrderRepository _ordersRepository;
        private readonly IHubContext<ShoppingCartHub> _hubContext;

        public OrdersController(IMovieRepository moviesRepository, ShoppingCart shoppingCart, IOrderRepository ordersRepository, IHubContext<ShoppingCartHub> hubContext)
        {
            _moviesRepository = moviesRepository;
            _shoppingCart = shoppingCart;
            _ordersRepository = ordersRepository;
            _hubContext = hubContext;

        }

        public async Task<IActionResult> Index()
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            string userRole = User.FindFirstValue(ClaimTypes.Role);

            var orders = await _ordersRepository.GetOrdersByUserIdAndRoleAsync(userId, userRole);
            return View(orders);
        }

        public IActionResult ShoppingCart()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var response = new ShoppingCartVM()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(response);
        }

        public async Task<IActionResult> AddItemToShoppingCart(int id)
        {
            var item = await _moviesRepository.GetMovieByIdAsync(id);

            if (item != null)
            {
                _shoppingCart.AddItemToCart(item);
                // Notify clients about the shopping cart update
                await _hubContext.Clients.All.SendAsync("ReceiveShoppingCartUpdate");
            }
            return RedirectToAction(nameof(ShoppingCart));
        }

        public async Task<IActionResult> RemoveItemFromShoppingCart(int id)
        {
            var item = await _moviesRepository.GetMovieByIdAsync(id);

            if (item != null)
            {
                _shoppingCart.RemoveItemFromCart(item);
                // Notify clients about the shopping cart update
                await _hubContext.Clients.All.SendAsync("ReceiveShoppingCartUpdate");
            }
            return RedirectToAction(nameof(ShoppingCart));
        }

        public async Task<IActionResult> CompleteOrder()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            string userEmailAddress = User.FindFirstValue(ClaimTypes.Email);

            await _ordersRepository.StoreOrderAsync(items, userId, userEmailAddress);
            await _shoppingCart.ClearShoppingCartAsync();

            return View("OrderCompleted");
        }
    }
}
