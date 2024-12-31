using AbstrationMethods.Entities.Enums;

namespace AbstrationMethods.Entities
{
    // Classe Rectangle que herda da classe abstrata Shape
    class Rectangle : Shape
    {
        // Propriedade que representa a largura do retângulo
        public double Width { get; set; }
        // Propriedade que representa a altura do retângulo
        public double Height { get; set; }

        // Construtor da classe Rectangle
        // Recebe largura, altura e cor como parâmetros
        // Chama o construtor da classe base (Shape) passando a cor
        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }
        // Sobrescreve o método abstrato Area() da classe base
        // Calcula e retorna a área do retângulo usando a fórmula: largura * altura
        public override double Area()
        {
            return Width * Height;
        }
    }
}
