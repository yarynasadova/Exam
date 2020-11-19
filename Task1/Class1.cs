using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{

    /**
    @class  Task
        on dll we create class Task
    
   */


    public class Task
    {
        ///@param Id int
        ///@param Title string
        ///@param  Description string
        ///@param startDate Date
        ///@param endtDate Date
        ///@param state state
        

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Date startDate { get; set; }
        public Date endtDate { get; set; }
        public State state { get; set; }
    }

    /**
   @enum State
   
  */
    public enum State
    {
        ///Open, InProgress, Close
        Open, InProgress, Close
    }



    /**
   @class Tasks
   
  */
    public class Tasks
    {
        ///  List<Task> Taskss = new List<Task>();
        ///  DeleteTask()
        ///  EditTask()
        ///  AddTask()
   

        List<Task> Taskss = new List<Task>();
        public void AddTask(Task t) 
        {
            Taskss.Add(t);
        }

        public void DeleteTask(Task t)
        {
            Taskss.Remove(t);
        }

        public void EditTask(Task t)
        {
            

        }
    }
}
