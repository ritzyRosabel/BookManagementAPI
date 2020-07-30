using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManagement.Core.API;
using BookManagement.Core.Interface;
using BookManagement.DAL.Entity;
using Microsoft.AspNetCore.Mvc;
namespace BookManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;
        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        [Route("API/v1/GetAuthurs")]
        public async Task<IActionResult> Get()
        {
            return  Ok( await _authorService.Get());
        }


        [HttpGet]
        [Route("API/v1/GetAuthurByID")]
        public async Task<IActionResult> GetAuthur(int id)
        {
            return Ok(await _authorService.GetById(id));
        }


        [HttpPost]
        [Route("API/v1/CreateAuthur")]
        public async Task<IActionResult> Create(AuthorCreateRequest request)
        {
            return Ok(await _authorService.CreateAuthor(request));
        }

        
        [HttpPut]
        [Route("API/v1/UpdateAuthur")]
        public async Task<IActionResult> Update(UpdateAuthorRequest request)
        {
            return Ok(await _authorService.UpdateAuthor(request));
        }


        [HttpDelete]
        [Route("API/v1/DeleteAuthur")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _authorService.Delete(id));
        }

    }
}
