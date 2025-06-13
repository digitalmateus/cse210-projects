using System;

namespace Shapes
{

    public abstract class Shape
    {
        private string _color;

        public Shape(string color = "Black")
        {
            _color = color;
            Console.WriteLine($"A shape of color {_color} has been created.");
        }

        public string GetColor()
        {
            return _color;
        }

        public void SetColor(string color)
        {
            _color = color;
            Console.WriteLine($"The color of the shape has been set to {_color}.");
        }

        public virtual double GetArea()
        {
            Console.WriteLine("This method should be overridden in derived classes.");
            return 0.0;
        }
    }
}