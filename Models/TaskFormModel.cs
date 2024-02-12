using System.ComponentModel.DataAnnotations;
using TaskBoardApp3.Data;
using TaskBoardApp3.Data.Models;
using static TaskBoardApp3.Data.DataConstants.Task;

namespace TaskBoardApp3.Models;

public class TaskFormModel
{
    public int Id { get; set; }
    
    [Required]
    [StringLength(TaskMaxTitle, MinimumLength = TaskMinTitle, ErrorMessage = "Title should be at least {2} and {1} long.")]
    public string Title { get; set; } 
    
    [Required]
    [StringLength(TaskMaxDescription, MinimumLength = TaskMinDescription, ErrorMessage = "Description should be at least {2} and {1} long.")]
    public string Description { get; set; }
    
    public int BoardId { get; set; }

    public IEnumerable<TaskBoardModel> Boards { get; set; } 
}