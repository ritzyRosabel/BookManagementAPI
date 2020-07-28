using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManagement.Core.API;
using BookManagement.Core.Interface;
using BookManagement.DAL.Entity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookManagement.API.Controllers
{
    [ApiController]
    public class BookController : ControllerBase
    {
        //If this code works, then it was writen by Rosabel Olugbenga. If it doesn't, then i can only say one thing  "IT IS WHAT IT IS".

        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        // GET: api/<BookController>
        [HttpGet]
        [Route("api/GetBooks")]

        public async Task<IActionResult> Get()
        {
            return Ok(await _bookService.GetBooks());
        }

        // GET api/<BookController>/5
        [HttpGet]
        [Route("api/GetBookById")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _bookService.GetBookByID(id));
        }

        // POST api/<BookController>
        [HttpPost]
        [Route("api/PostBook")]

        public async Task<IActionResult> Post([FromBody] BookRequest book)
        {
            return Ok(await _bookService.CreateBooks(book));

        }
        [HttpPut]
        // PUT api/<BookController>/5
        [Route("api/UpdateBook")]
        public async Task<IActionResult> Put([FromBody] UpdateBookRequest book)
        {
            return Ok(await _bookService.UpdateABook(book));
        }

        // DELETE api/<BookController>/5
        [HttpDelete]
        [Route("api/DeleteBook")]

        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _bookService.DeleteABook(id));
        }
    }
}
