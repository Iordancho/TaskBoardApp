using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TaskBoardApp3.Data.Models;
using static TaskBoardApp3.Data.DataConstants.Task;

namespace TaskBoardApp3.Models;

public class TaskViewModel
{
    public int Id { get; set; }

    [Required]
    [MaxLength(TaskMaxTitle)]
    [MinLength(TaskMinTitle)]
    public string Title { get; set; } = string.Empty;
    
    [Required]
    [MaxLength(TaskMaxDescription)]
    [MinLength(TaskMinDescription)]
    public string Description { get; set; } = string.Empty;
    
    public int? BoardId { get; set; }
    
    [Required]
    public string Owner { get; set; } = String.Empty;
    
}