using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskBoardApp3.Data.Configuration;
using TaskBoardApp3.Data.Models;
using Task = TaskBoardApp3.Data.Models.Task;


namespace TaskBoardApp3.Data;

public class TaskBoardAppDbContext : IdentityDbContext
{
    public TaskBoardAppDbContext(DbContextOptions<TaskBoardAppDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder
            .Entity<Task>()
            .HasOne(t => t.Board)
            .WithMany(b => b.Tasks)
            .HasForeignKey(t => t.BoardId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.ApplyConfiguration(new UserConfiguration());
        builder.ApplyConfiguration(new BoardConfiguration());
        builder.ApplyConfiguration(new TaskConfiguration());
        
        base.OnModelCreating(builder);
    }

    public DbSet<Task> Tasks { get; set; }
    public DbSet<Board> Boards { get; set; }
}