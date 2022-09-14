using ODataSample.Models;
namespace ODataSample.Services
{
    public interface ITodoService
    {
        IQueryable<TodoItem> RetrieveAllTodoItems();
    }
}
