using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoIT.Model
{


    public class Todo // field 
    {
        private readonly int todoId;
        private string description;
        private bool done;
        private Person assignee;

      public Todo(int todoId)//constructor
        {
            this.todoId = todoId;
        }
        public Todo(int todoId, string description)
            :this(todoId)//Constructor
        {
            this.description = description;
            this.done = false;
        }

        public int TodoId
        {
            get
            {
                return todoId;
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    description = value;
                }
                else
                {
                    
                }
               
            }
        }
        
        public bool Done
        {
            get { return done; }
            set { done = value; }
        }
        public Person Assignee
        {
            get { return assignee; }
            set { assignee = value; }
            
        }

    }
}



