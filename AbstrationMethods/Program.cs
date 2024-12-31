using AbstrationMethods.Entities;
using AbstrationMethods.Entities.Enums;
using System.Globalization;

namespace AbstrationMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cria uma lista para armazenar objetos do tipo Shape
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            // Loop para criar cada forma
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (R/C)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());                
                if (ch == 'r') // Se for um retângulo, solicita largura e altura
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color)); // Cria um novo retângulo e adiciona à lista
                }
                else
                {
                    Console.Write("Radius: ");  // Se for um círculo, solicita o raio
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color)); // Cria um novo círculo e adiciona à lista
                }
            }
            Console.WriteLine();
            Console.WriteLine("Shape Areas: ");
            foreach (Shape shape in list) // Loop para imprimir a área de cada forma
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }


        }
    }
}
