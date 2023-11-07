using Microsoft.AspNetCore.Mvc;

namespace tasks
{
    public interface ITaskService
    {
        List<Taskk> GetTasks();
        Taskk CreateTask(string name, string description, DateTime dueDate, Importance importance);
        string UpdateTask(int id, string name, int price);
        //string DeleteTask(Taskk t);
       
    }
}
