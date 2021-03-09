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

        public Todo(int todoid)//constructor
        {
            this.todoId = todoid;
        }
        public Todo( string description, bool done, Person assignee)//Constructor
        {
           
            this.description = description;
            this.done = done;
            this.assignee = assignee;
        }
        public int Todoid
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



