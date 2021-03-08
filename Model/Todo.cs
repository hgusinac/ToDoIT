using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoIT.Model
{
}

public class Todo // field 
{
    private readonly int Todoid;
    string description;
    bool done;


    public Todo()//
    {
        this.Todoid = TodoId;
        this.Description = Description;
        this.Done = Done;
       
    }
    public string Description
    {
        get { return description; }
        set { description = value; }
    }
    public bool Done 
    {
        get { return done; }
        set { done = value; } 
    }
    public int TodoId 
    {
        get { return TodoId; }
        set { TodoId = value; }
       
    }

}



