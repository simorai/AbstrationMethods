using AbstrationMethods.Entities.Enums;

namespace AbstrationMethods.Entities
{
    // Classe abstrata Shape (Forma)
    internal abstract class Shape
    {
        // Propriedade que representa a cor da forma
        // Usa o enum Color definido em AbstrationMethods.Entities.Enums
        public Color Color  { get; set; }
        // Construtor da classe Shape
        // Recebe um parâmetro do tipo Color e inicializa a propriedade Color
        public Shape(Color color)
        {
            Color = color;
        }

        // Método abstrato para calcular a área
        // Não tem implementação aqui, deve ser implementado nas classes derivadas
        public abstract double Area();
    }
}
