using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class TestShapes
    {
        static void Main(string[] args)
        {
            IList<IShape> shapes = new List<IShape>()
            {
            new Triangle(2,5.5,5),
            new Rectangle(5,4.4),
            new Circle(2.3),
            new Triangle(5,5,5),
            new Rectangle(12.8,4),
            new Circle(5),
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.GetType().Name + "--> area: {0}, perimeter: {1}",
                    shape.CalculateArea(), shape.CalculatePerimeter());
            }
        }
    }
}

