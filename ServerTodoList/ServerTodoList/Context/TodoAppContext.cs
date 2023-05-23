using Microsoft.EntityFrameworkCore;
using ServerTodoList.Model;

namespace ServerTodoList.Data;

public class TodoAppContext : DbContext
{
    public TodoAppContext(DbContextOptions<TodoAppContext> options) : base(options)
    {
    }

    public DbSet<User> Todo { set; get; }
    public DbSet<TodoTask> Task { set; get; }

}