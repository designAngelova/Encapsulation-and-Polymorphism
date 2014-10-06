using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle:IShape
    {
        private double radius;
        public Circle(double radius)
        {
            this.Radius = radius;

        }
        public double Radius 
        {
            get
            {
                return this.radius;
            }

            set 
            {
                if (value<=0)
                {
                    throw new NullReferenceException("Radius can not be null or negative");
                }
                this.radius = value;
            }
        }

        public double CalculateArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }

        public double CalculatePerimeter()
        {
            return 2*Math.PI*this.Radius;
        }

       
    }
}
