using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle : BasicShape
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }



        public double A
        {
            get
            {
                return this.a;
            }
            set
            {
                if (value <= 0)
                {
                    throw new NullReferenceException("Value of side a can not be 0 or negative");

                }
                this.a = value;
            }
        }

        public double B
        {
            get
            {
                return this.b;
            }
            set
            {
                if (value <= 0)
                {
                    throw new NullReferenceException("Value of side a can not be 0 or negative");
                }
                this.b = value;
            }
        }

        public double C
        {
            get
            {
                return this.c;
            }
            set
            {
                if (value <= 0)
                {
                    throw new NullReferenceException("Value of side a can not be 0 or negative");
                }
                this.c = value;
            }
        }

        public override double CalculateArea()
        {
            double p = this.A+this.B+this.C/2;
            return Math.Sqrt(p * (p - 1) * (p - b) * (p - c));
        }

        public override double CalculatePerimeter()
        {
            return this.A + this.B + this.C;

        }
    }
}
