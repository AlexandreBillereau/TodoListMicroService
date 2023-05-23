using Microsoft.AspNetCore.Mvc;
using ServerTodoList.Data;
using ServerTodoList.Model;

namespace ServerTodoList.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TodoController : ControllerBase
{
    private static TodoAppContext _db;
    
    public TodoController(TodoAppContext db)
    {
        _db = db;
    }
    
    // [HttpPost("add")]
    // public async Task<bool> add(TodoTask task)
    // {
    //     
    // }
}