
namespace HomeWork3
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private double dateTime;
        private string hobby;
        private string gender;

        public Person(string firstName, string lastName, double dateTime, string hobby, string gender)
        {


        }

        public Person()
        {

        }
        public string FirstName { get { return firstName; } set { firstName = value; } }

        public string LastName { get { return lastName; } set { lastName = value; } }


        public Double DateTime { get { return dateTime; } set { dateTime = value; } }


        public String Hobby { get { return hobby; } set { hobby = value; } }

        public string Gender { get { return gender; } set { gender = value; } }
    
    
    }

 
    
}