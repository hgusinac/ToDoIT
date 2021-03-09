
using PersonClass.Model;
using System;


namespace ToDoIT
{

    class Program
    {
        static void Main(string[] args)
        {


            int personID = 1;
            string firstName = "Pontus";
            string lastName = "Sinklair";
           
            string firstName2 = string.Empty;

            Person person = new Person(personID, firstName, lastName);

            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
            Console.WriteLine(person.PersonID);
        }
    }
}
