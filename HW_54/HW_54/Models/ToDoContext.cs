using Microsoft.EntityFrameworkCore;
namespace HW_54.Models;

public class ToDoContext : DbContext
{
    public ToDoContext(DbContextOptions<ToDoContext> options) : base(options){}
    
    public DbSet<ToDoTask> Tasks { get; set; }
}