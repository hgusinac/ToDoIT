using System;
using ToDoIT.Model;


namespace ToDoIT
{




    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(1);
            Todo todo = new Todo(100);

            Console.WriteLine(todo.Description);



        }
    }
}
