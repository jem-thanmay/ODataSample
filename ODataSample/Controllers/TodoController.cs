using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ODataSample.Models;
using ODataSample.Services;

namespace ODataSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService todoService;
        public TodoController(ITodoService todoService) =>
            this.todoService = todoService;
        [HttpGet]
        public ActionResult<IQueryable<TodoItem>> GetAllTodoItems();
        
         IQueryable<TodoItem> retrievedItems=
            this.todoService.RetrieveAllTodoItems();
         return Ok(retrievedItems);
         




    }
}
