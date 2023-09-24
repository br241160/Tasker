using API.Data;
using API.Entities;
using API.Errors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly TaskerContext _context;

        public TaskController(TaskerContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<TaskerTask>>> GetTasks()
        {
            return Ok(await _context.TaskerTasks.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TaskerTask>> GetTask(int id)
        {
            return Ok(await _context.TaskerTasks.Where(x => x.Id == id).FirstAsync());
        }

        [HttpPost]
        public async Task<ActionResult<List<TaskerTask>>> AddTask(TaskerTask taskerTask)
        {
            _context.TaskerTasks.Add(taskerTask);
            await _context.SaveChangesAsync();
            return Ok(await _context.TaskerTasks.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<TaskerTask>> UpdateTask(TaskerTask taskerTask)
        {
            var tsk = await _context.TaskerTasks.Where(x => x.Id == taskerTask.Id).FirstOrDefaultAsync();
            if (tsk == null) return NotFound(new ApiResponse(404));

            tsk.Id = taskerTask.Id;
            tsk.Name = taskerTask.Name;
            tsk.Details = taskerTask.Details;
            tsk.Done = taskerTask.Done;

            return Ok(await _context.TaskerTasks.Where(x => x.Id == taskerTask.Id).FirstAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<TaskerTask>>> DeleteTask(int id)
        {
            var tsk = await _context.TaskerTasks.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (tsk == null) return NotFound(new ApiResponse(404));

            _context.TaskerTasks.Remove(tsk);
            await _context.SaveChangesAsync();
            return Ok(await _context.TaskerTasks.ToListAsync());
        }
        
    }
}