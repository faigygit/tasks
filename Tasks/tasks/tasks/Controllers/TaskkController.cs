using Microsoft.AspNetCore.Mvc;

namespace tasks.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class TaskkController : ControllerBase
    { 
        private readonly ITaskService taskService;
        public TaskkController(ITaskService taskService)
        {
            this.taskService = taskService;
        }

        [HttpGet()]
        public ActionResult<List<Taskk>> Get()
        {
            return taskService.GetTasks();
        }

        [HttpPost()]
        public ActionResult<Taskk> Post(string name, string description, DateTime dueDate, Importance importance)
        {
            return taskService.CreateTask(name, description, dueDate, importance);
        }
        [HttpPut("{id}")]
        public ActionResult<string> Put(string name, string description, DateTime dueDate, Importance importance)
        {
            return taskService.UpdateTask(name, description, dueDate, importance);
        }

        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            return taskService.DeleteTask(id);
        }
    }
}
