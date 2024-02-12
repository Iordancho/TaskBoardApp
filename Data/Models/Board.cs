using System.ComponentModel.DataAnnotations;
using static TaskBoardApp3.Data.DataConstants.Board;

namespace TaskBoardApp3.Data.Models;

public class Board
{
    public int Id { get; set; }
    
    [Required]
    [MaxLength(BoardMaxName)]
    public string Name { get; set; }
    
    public ICollection<Task> Tasks { get; set; } = new List<Task>();
}