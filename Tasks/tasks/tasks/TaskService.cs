namespace tasks
{

    public class TaskService: ITaskService
    {
        static List<Taskk> myTasks = new List<Taskk>
        {
            new Taskk("DANCE", "very fun", DateTime.Today, Importance.a),
            new Taskk("CLEAN", "very well", DateTime.Today, Importance.a),
            new Taskk("SWIM", "very healthy", DateTime.Today, Importance.a),
            new Taskk("WORK", "very important and annoying", DateTime.Today, Importance.a)

        };

        public List<Taskk> GetTasks()
        {
            return myTasks;
        }
        public Taskk CreateTask(string name, string description, DateTime dueDate, Importance importance)
        {
            return new Taskk(name,description,dueDate,importance);
        }
        public string UpdateProduct(string name, string description, DateTime dueDate, Importance importance)
        {

            if (id > 1 && id < myTasks.Count())
            {
                string old = myTasks[id - 1].Name;
                myTasks[id - 1].Name = name;
                myTasks[id - 1].Description = description;
                myTasks[id - 1].DueDate = dueDate;
                myTasks[id - 1].Importance = importance;
                return old + " updated to " + name;
            }
            return "can't be updated!";
        }
        public string DeleteProduct(int id)
        {

            if (id > 1 && id < myTasks.Count())
            {
                string old = myTasks[id - 1].Name;
                myTasks.Remove(myTasks[id - 1]);
                return old + " deleted";
            }
            return "doesn't exist!!";
        }
    }
}
