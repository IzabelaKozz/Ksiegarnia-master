﻿using Ksiegarnia.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ksiegarnia.Data;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;

namespace Ksiegarnia.Controllers
{
    
    public class CartController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public CartController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        [Authorize]
        public IActionResult Index()
        {
            var cart = HttpContext.Session.GetString("Cart");
            var cartModel = string.IsNullOrEmpty(cart) ? new Cart() : JsonConvert.DeserializeObject<Cart>(cart);
            return View(cartModel);
        }

        [Authorize]
        public IActionResult AddToCart(int bookId, int quantity)
        {
           
            
                var book = _bookRepository.GetBookById(bookId);

                var cart = HttpContext.Session.GetString("Cart");
                var cartModel = string.IsNullOrEmpty(cart) ? new Cart() : JsonConvert.DeserializeObject<Cart>(cart);

                var cartItem = cartModel.Items.FirstOrDefault(item => item.BookId == bookId);

                if (cartItem == null)
                {
                    cartModel.Items.Add(new CartItem
                    {
                        BookId = book.BookId,
                        Title = book.Title,
                        Quantity = quantity,
                        Price = book.Price
                    });
                }
                else
                {
                    cartItem.Quantity += quantity;
                }

                HttpContext.Session.SetString("Cart", JsonConvert.SerializeObject(cartModel));

                return RedirectToAction("Index");
            
        }
        [HttpPost]
        [Authorize]
        public IActionResult UpdateQuantity(int bookId, int quantity)
        {
            var cart = HttpContext.Session.GetString("Cart");
            var cartModel = string.IsNullOrEmpty(cart) ? new Cart() : JsonConvert.DeserializeObject<Cart>(cart);

            var cartItem = cartModel.Items.FirstOrDefault(item => item.BookId == bookId);

            if (cartItem != null)
            {
                cartItem.Quantity = quantity;
            }

            HttpContext.Session.SetString("Cart", JsonConvert.SerializeObject(cartModel));

            return RedirectToAction("Index");
        }
        [Authorize]
        public IActionResult RemoveFromCart(int bookId)
        {
            var cart = HttpContext.Session.GetString("Cart");
            var cartModel = string.IsNullOrEmpty(cart) ? new Cart() : JsonConvert.DeserializeObject<Cart>(cart);

            var cartItem = cartModel.Items.FirstOrDefault(item => item.BookId == bookId);

            if (cartItem != null)
            {
                cartModel.Items.Remove(cartItem);
            }

            HttpContext.Session.SetString("Cart", JsonConvert.SerializeObject(cartModel));

            return RedirectToAction("Index");
        }



        // Inne metody kontrolera
    }
}
