using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    public class Telefons

    {
        public string Size { get; set; }

        public string Model { get; set; }

        public string Mark { get; set; }

        public void Call()
        {
        }
        public void SMS()
        {
        }

    }
}



namespace HomeWork3 
{

    public class Car

    {

        public string Brand { get; set; }

        public string NumberPlate { get; set; }

        public string Speed { get; set; }

        public void StartToDrive()
        {
            Speed = 10;
            Console.WriteLine("Sākam braukt");
        }
        public double GoFaster()
        { 
            Speed += 10;
            Console.WriteLine("Ātrums - " + Speed);
         
        }
       


    }
 } 