using Ispit.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Ispit.API
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

        public DbSet<TodoList> TodoLists { get; set; }
    }
}
