using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Date startDate { get; set; }
        public Date endtDate { get; set; }
        public State state { get; set; }
    }

    public enum State
    {
        Open, InProgress, Close
    }

    public class Tasks
    {
        List<Task> Taskss = new List<Task>();
        public void AddTask(Task t) 
        { 

        }
    }
}
