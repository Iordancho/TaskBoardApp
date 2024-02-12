using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskBoardApp3.Data;
using TaskBoardApp3.Models;
using Task = TaskBoardApp3.Data.Models.Task;


namespace TaskBoardApp3.Controllers;

public class TaskController : Controller
{
    private readonly TaskBoardAppDbContext data;

    public TaskController(TaskBoardAppDbContext _data)
    {
        data = _data;
    }
    
    [HttpGet]
    public async Task<IActionResult> Create()
    {
        TaskFormModel taskFormModel = new TaskFormModel()
        {
            Boards = GetBoards()
        };

        return View(taskFormModel);
    }

    [HttpPost]
    public async Task<IActionResult> Create(TaskFormModel taskModel)
    {
        string currentUserId = GetUserId();

        // if (!ModelState.IsValid)
        // {
        //     var errors = ModelState.Values.SelectMany(v => v.Errors);
        //     taskModel.Boards = GetBoards();
        //     return View(taskModel);
        // }

        Task task = new Task()
        {
            Title = taskModel.Title,
            Description = taskModel.Description,
            BoardId = taskModel.BoardId,
            OwnerId = currentUserId,
            CreatedOn = DateTime.Now
        };
        await data.AddAsync(task);
        await data.SaveChangesAsync();

        return RedirectToAction("Index", "Board");
    }

    public async Task<IActionResult> Details(int id)
    {
        var task = await data.Tasks
            .Where(t => t.Id == id)
            .Select(t => new TaskDetailsViewModel()
            {
                Id = t.Id,
                Title = t.Title,
                Description = t.Description,
                CreatedOn = t.CreatedOn.Value.ToString("dd/MM/yyyy HH:mm"),
                Board = t.Board.Name,
                Owner = t.Owner.UserName
            })
            .FirstOrDefaultAsync();

        if (task == null)
        {
            return BadRequest();
        }

        return View(task);
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var task = await data.Tasks.FindAsync(id);

        if (task == null)
        {
            return BadRequest();
        }

        string currentUserId = GetUserId();
        if (currentUserId != task.OwnerId)
        {
            return Unauthorized();
        }

        TaskFormModel taskFormModel = new TaskFormModel()
        {
            Title = task.Title,
            Description = task.Description,
            BoardId = task.BoardId,
            Boards = GetBoards()
        };

        return View(taskFormModel);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(TaskFormModel taskModel)
    {
        var task = await data.Tasks.FindAsync(taskModel.Id);

        if (task == null)
        {
            return BadRequest();
        }

        string currentUserId = GetUserId();
        if (currentUserId != task.OwnerId)
        {
            return Unauthorized();
        }

        task.Title = taskModel.Title;
        task.Description = taskModel.Description;
        task.BoardId = taskModel.BoardId;

        await data.SaveChangesAsync();
        return RedirectToAction("Index", "Board");
    }

    [HttpGet]
    public async Task<IActionResult> Delete(int id)
    {
        var task = await data.Tasks.FindAsync(id);
        
        if (task == null)
        {
            return BadRequest();
        }

        string currentUserId = GetUserId();
        if (currentUserId != task.OwnerId)
        {
            return Unauthorized();
        }

        TaskViewModel taskModel = new TaskViewModel()
        {
            Title = task.Title,
            Description = task.Description,
            Id = task.Id
        };

        return View(taskModel);
    }

    public async Task<IActionResult> Delete(TaskViewModel taskModel)
    {
        var task = await data.Tasks.FindAsync(taskModel.Id);
        
        if (task == null)
        {
            return BadRequest();
        }

        string currentUserId = GetUserId();
        if (currentUserId != task.OwnerId)
        {
            return Unauthorized();
        }

        data.Tasks.Remove(task);
        await data.SaveChangesAsync();

        return RedirectToAction("Index", "Board");
    }

    private string GetUserId()
    {
        return User.FindFirstValue(ClaimTypes.NameIdentifier);
    }

    private IEnumerable<TaskBoardModel> GetBoards()
    {
        return data.Boards
            .Select(b => new TaskBoardModel()
            {
                Id = b.Id,
                Name = b.Name
            });
    }
}