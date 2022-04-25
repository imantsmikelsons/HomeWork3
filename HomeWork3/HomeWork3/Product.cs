
namespace HomeWork3
{
    public class Product
   {

        private string _name;
        private double _width;
        private double _lenght;
        private double _weight;

        public Product()
        {

        }

        public Product(string name, double width, double lenght, double weight)
        {
            _name = name;
            _width = width;
            _lenght = lenght;
            _weight = weight;
        }

        public string Name { get { return _name; } }
        public double Width { get { return _width; } }
        public double Lenght { get { return _lenght; } }
        public double Weight { get { return _weight; } }
        
       

        public void PrintInfo()
        {
            Console.WriteLine($"Produkta {_name} parametri");
            Console.WriteLine($"Produkta platums : {_width} cm");
            Console.WriteLine($"Produkta  garums : {_lenght} cm");
            Console.WriteLine($"Produkta   svars : {_weight} kg");
        }

    }


}