using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.VisualBasic;
using Board = TaskBoardApp3.Data.Models.Board;
using Task = TaskBoardApp3.Data.Models.Task;



namespace TaskBoardApp3.Data.Configuration;

public class TaskConfiguration: IEntityTypeConfiguration<Task>
{
    
    public void Configure(EntityTypeBuilder<Task> builder)
    {
        builder.HasData(SeedTasks());
    }

    private IEnumerable<Task> SeedTasks()
    {
        return new Task[]{   
            new Task()
            {
                Id = 1,
                Title = "Impove CSS styles",
                Description = "Implement better styling",
                CreatedOn = DateTime.Now.AddDays(-200),
                OwnerId = ConfigurationHelper.TestUser.Id,
                BoardId = ConfigurationHelper.OpenBoard.Id
            },
            new Task()
            {
                Id = 2,
                Title = "Android Client App",
                Description = "Create Android Client App",
                CreatedOn = DateTime.Now.AddDays(-100),
                OwnerId = ConfigurationHelper.TestUser.Id,
                BoardId = ConfigurationHelper.OpenBoard.Id
            },
            new Task()
            {
                Id = 3,
                Title = "Desktop client App",
                Description = "Create Desktop client App",
                CreatedOn = DateTime.Now.AddDays(-50),
                OwnerId = ConfigurationHelper.TestUser.Id,
                BoardId = ConfigurationHelper.DoneBoard.Id
            },
            new Task()
            {
                Id = 4,
                Title = "Create Tasks",
                Description = "Implement [Create tasks] page for adding tasks",
                CreatedOn = DateTime.Now.AddDays(-60),
                OwnerId = ConfigurationHelper.TestUser.Id,
                BoardId = ConfigurationHelper.InProgressBoard.Id
            }
        };
    }
    
}