
namespace HomeWork3
{
    public class Product
   {


        private double _width;
        private double _lenght;
        private double _weight;
        private string _name;

        public Product(string name, double width, double height, double weight)
        {
            _weight = weight;
            _name = name;
            _width = width;
            _lenght = height;

        }

        public double Width { get { return _width; } }
        public double Height { get { return _lenght; } }
        public string Name { get { return _name; } }
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