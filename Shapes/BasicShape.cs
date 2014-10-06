using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class BasicShape : IShape
    {
       
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();

        

    }
}
