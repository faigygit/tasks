using System.Xml.Linq;

namespace tasks
{
    public enum Importance{a,b,c,d};
    public class Taskk
    {
        int c = 0;
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public  Importance Importance { get; }
        public int Id { get; set; }
        public Taskk(string name, string description, DateTime dueDate, Importance importance)
        {
            Id = c++; 
            Name = name;
            Description = description;
            DueDate = dueDate;
            Importance = importance;

        }

    }
}
