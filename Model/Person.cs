using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoIT.Model
{

    public class Person//Fields
    {
        private readonly int personId;
        private string firstName;
        private string lastName;


        public Person(int personId)//construktor med en input parameter
        {
            this.personId = personId;
        }
        public Person(string firstName, string lastName)//Constructor
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FirstName//Proporties
        {
            get { return firstName; }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    firstName = value;
                }
            }
        }
        public string LastName//Proporties
        {
            get { return lastName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    lastName = value;
                }
            }
        }
        public int PersonId
        {
            get { return personId; }
        }

    }
}
