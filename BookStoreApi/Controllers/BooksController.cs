using BookStoreApi.Models;
using BookStoreApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BooksService _bookService;
        public BooksController(BooksService booksService)
        {
            _bookService = booksService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _bookService.GetAsync();
            return Ok(result);
        }

        [HttpGet("{id:length(24)}")]
        public async Task<IActionResult> Get(string id)
        {
            var book = await _bookService.GetAsync(id);
            return book is null ? NotFound() : Ok(book);
        }
        [HttpPost]
        public async Task<IActionResult> Add(Book newBook)
        {
            await _bookService.CreateAsync(newBook);
            return CreatedAtAction(nameof(Get), new { id = newBook.Id },newBook);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Book updatedBook)
        {
            var book = await _bookService.GetAsync(id);

            if (book is null)
            {
                return NotFound();
            }

            updatedBook.Id = book.Id;

            await _bookService.UpdateAsync(id, updatedBook);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var book = await _bookService.GetAsync(id);

            if (book is null)
            {
                return NotFound();
            }

            await _bookService.RemoveAsync(book.Id);

            return NoContent();
        }
    }
}
