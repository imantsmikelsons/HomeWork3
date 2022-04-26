
using DocuSign.eSign.Model;

namespace HomeWork3
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public string Hobby;
        public string Gender;

        public Person()
        {

        }

        public Person(string firstName)
        {
            FirstName = firstName;
            Console.WriteLine($"Creating person name {firstName}");
            LastName = lastName;
            Console.WriteLine($"Creating person lastname {lastName}");
            Hobby = hobby;
            Console.WriteLine($"Creating person hobby {hobby}");
            Gender = gender;
            Console.WriteLine($"Creating person hobby {gender}");
        }

        public Person(string firstName, string lastName, string hobby, string gender)
        {

        }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string hobby { get; set; }
        public string gender { get; set; }
    

        public void PrintInfo()
        {
            Console.WriteLine($"Vārds:{firstName}");
            Console.WriteLine($"Uzvārds:{lastName}");
            Console.WriteLine($"Hobijs:{hobby}");
            Console.WriteLine($"Dzimums:{gender}");
        }


    }

 
    
}