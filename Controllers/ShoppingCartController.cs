using Cupcakes.Models;
using Cupcakes.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cupcakes.Controllers
{
    public class ShoppingCartController : Controller
    {

        private readonly IPieReposatriy _pieRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IPieReposatriy pieRepository, ShoppingCart shoppingCart)
        {
            _pieRepository = pieRepository;
            _shoppingCart = shoppingCart;
        }
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int pieId)
        {
            var selectedPie = _pieRepository.GetAll.FirstOrDefault(p => p.pieId == pieId);

            if (selectedPie != null)
            {
                _shoppingCart.AddToCart(selectedPie, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int pieId)
        {
            var selectedPie = _pieRepository.GetAll.FirstOrDefault(p => p.pieId == pieId);

            if (selectedPie != null)
            {
                _shoppingCart.RemoveFromCart(selectedPie);
            }
            return RedirectToAction("Index");
        }
    }
}
