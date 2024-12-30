using AbstrationMethods.Entities.Enums;

namespace AbstrationMethods.Entities
{
    internal abstract class Shape
    {
        public Color Color  { get; set; }        

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
