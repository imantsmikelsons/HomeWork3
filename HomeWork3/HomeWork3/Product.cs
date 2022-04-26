
namespace HomeWork3
{
    public class Product
   {
        private object name;
        private object width;
        private object lenght;
        private object weight;

        public Product()
        {

        }

        public Product(string name, double width, double lenght, double weight)
        {
            Name = name;
            Width = width;
            Lenght = lenght;
            Weight = weight;
        }

        public string Name { get; set;}
        public double Width { get; set;}
        public double Lenght { get; set;}
        public double Weight { get; set;}
        
       

        public void PrintInfo()
        {
            Console.WriteLine($"Produkta {name} parametri");
            Console.WriteLine($"Produkta platums : {width} cm");
            Console.WriteLine($"Produkta  garums : {lenght} cm");
            Console.WriteLine($"Produkta   svars : {weight} kg");
        }

    }


}