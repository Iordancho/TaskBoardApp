using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static TaskBoardApp3.Data.DataConstants.Task;

namespace TaskBoardApp3.Data.Models;

public class Task
{
    public int Id { get; set; }

    [Required]
    [MaxLength(TaskMaxTitle)]
    [Comment("Task Title")]
    public string Title { get; set; } = string.Empty;
    
    [Required]
    [MaxLength(TaskMaxDescription)]
    [Comment("Task Description")]
    public string Description { get; set; } = string.Empty;
    
    public DateTime? CreatedOn { get; set; }
    
    public int BoardId { get; set; }
    [ForeignKey(nameof(BoardId))]
    public Board? Board { get; set; }
    
    [Required]
    public string OwnerId { get; set; }
    [ForeignKey(nameof(OwnerId))]
    public IdentityUser Owner { get; set; }
}


// •	Id – a unique integer, Primary Key
// •	Title – a string with min length 5 and max length 70 (required)
// •	Description – a string with min length 10 and max length 1000 (required)
// •	CreatedOn – date and time
// •	BoardId – an integer
// •	Board – a Board object
// •	OwnerId – an integer (required)
// •	Owner – an IdentityUser object
