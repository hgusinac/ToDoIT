namespace ToDoIT.Model
{
    public class Person
    {
       private readonly int personId;
       public string firstName;
       public string lastName;
  
        public Person(string firstName)
        {
            this.FirstName = firstName;

        }
        public Person()
        {
            this.personId = PersonId;
            this.firstName = FirstName;
            this.lastName = LastName;
        }
        public string FirstName 
        {
            get{ return firstName; }
            set { firstName = value; }
        }
        public string LastName 
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private  int PersonId
        {
            get { return personId;}
            
        }

    }
    }



