using System.ComponentModel.DataAnnotations;

namespace TodoList.Models
{
    public class Task
    {
       public int Id { get; set; }

        public string Title { get; set; }

        public string Comments { get; set; }
        
    }
}