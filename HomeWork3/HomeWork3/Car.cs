
namespace HomeWork3
{
    public class Car
    {
        public string Brand { get;}
        public string NumberPlate { get;}
        public double Speed { get; private set;}

        public void StartToDrive()
        {
            Speed = 10;
            Console.WriteLine("Sākam braukt");

        }

        public double GoFaster()
        {
            Speed += 10;
            Console.WriteLine($"Ātrums - {Speed}");
            return Speed;
        }


        public void SlowDown()
        {

            {
                Speed -= 10;
                Console.WriteLine("Bremzēt - ");
            }
        }

        public void Stop()
        {
            Speed = 0;
            Console.WriteLine("Stop");
        }
        public void Beep()
        {
            Console.WriteLine("Beep");
        }

    }
}