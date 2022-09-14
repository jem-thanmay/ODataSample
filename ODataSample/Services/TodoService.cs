using ODataSample.Models;

namespace ODataSample.Services
{
    public class TodoService : ITodoService
    {
        public IQueryable<TodoItem> RetrieveAllTodoItems()
        {
            return new List<TodoItem>
            {
                new TodoItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Buy Pencils",
                    IsComplete = true,
                },
            new TodoItem
            {
                Id = Guid.NewGuid(),
                Name = "Finish Book",
                IsComplete = false,
            },
            new TodoItem
            {
                Id = Guid.NewGuid(),
                Name = "Visit Bank",
                IsComplete = true,
            },
            new TodoItem
            {
                Id = Guid.NewGuid(),
                Name = "Call Mona",
                IsComplete = false,
            }
            }.AsQueryable();
        }
    }
}

