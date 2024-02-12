using System.ComponentModel.DataAnnotations;
using Task = TaskBoardApp3.Data.Models.Task;
using static TaskBoardApp3.Data.DataConstants.Board;

namespace TaskBoardApp3.Models;

public class BoardViewModel
{
    public int Id { get; set; }
    
    [Required]
    [StringLength(BoardMaxName, MinimumLength = BoardMinName)]
    public string Name { get; set; } = String.Empty;

    public IEnumerable<TaskViewModel> Tasks { get; set; } = new List<TaskViewModel>();
}