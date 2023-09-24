using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class TaskerContext : DbContext
    {
        public TaskerContext(DbContextOptions<TaskerContext> options) : base(options)
        {
        }

        public DbSet<TaskerTask> TaskerTasks { get; set; }
    }
}