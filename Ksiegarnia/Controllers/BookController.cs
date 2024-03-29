﻿using Ksiegarnia.Data;
using Ksiegarnia.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ksiegarnia.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        
        public IActionResult Index()
        {
            var books = _bookRepository.GetAllBooks();
            foreach (var book in books)
            {
                // Ustaw ścieżkę do pliku obrazu okładki dla każdej książki
                book.CoverImagePath = $"/images/{book.BookId}.jpg"; // Użyj string interpolacji, aby łatwiej tworzyć ścieżki
            }
            return View(books);
        }
        [Authorize]
        public IActionResult Details(int id)
        {
            var book = _bookRepository.GetBookById(id);
            return View(book);
        }
    }
}
