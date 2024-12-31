using AbstrationMethods.Entities.Enums;

namespace AbstrationMethods.Entities
{
    // Classe Circle que herda da classe abstrata Shape
    class Circle : Shape
    {
        // Propriedade que representa o raio do círculo
        public double Radius { get; set; }

        // Construtor da classe Circle
        // Recebe o raio e a cor como parâmetros
        // Chama o construtor da classe base (Shape) passando a cor
        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        // Sobrescreve o método abstrato Area() da classe base
        // Calcula e retorna a área do círculo usando a fórmula: pi * raio * raio
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
