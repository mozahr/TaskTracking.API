using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TT.Services.Task;

namespace TaskTracking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;
        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet("get")]
        public virtual IActionResult Get()
        {
            var model = _taskService.GetTasks();

            return Ok(model);
        }
  
        [HttpPost("insert")]
        public virtual IActionResult insert(TT.Core.Domain.Task task)
        {
             _taskService.InsertTask(task);

            return Ok(true);
        }
        [HttpPost("edit")]
        public virtual IActionResult edit(TT.Core.Domain.Task task)
        {
            _taskService.UpdateCustomer(task);

            return Ok(true);
        }
        [HttpGet("delete/{id:int}")]
        public virtual IActionResult delete(int id)
        {
            var task = new TT.Core.Domain.Task
            {
                Id = id
            };
            _taskService.DeleteTask(task);

            return Ok(true);
        }
    }
}
