using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace GauApi.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<ToDoItem> TodoItems { get; set; } = null!;
    }
}