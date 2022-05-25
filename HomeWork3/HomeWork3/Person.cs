
using DocuSign.eSign.Model;

namespace HomeWork3
{
    public class Person
    {

        public Person()
        {

        }

        public Person(string firstName, string lastName, string hobby, string gender)

        {
            FirstName = firstName;
            LastName = lastName;
            Hobby = hobby;
            Gender = gender;
    }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Hobby { get; set; }
        public string Gender { get; set; }
        public int BirthDate { get; set; }

        public int GetAge()
        {
            return DateTime.Now.Year - BirthDate;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Vārds:{FirstName}");
            Console.WriteLine($"Uzvārds:{LastName}");
            Console.WriteLine($"Hobijs:{Hobby}");
            Console.WriteLine($"Dzimums{Gender}");
            Console.WriteLine($"Vecums:{GetAge()}");
        }


    }

 
    
}

