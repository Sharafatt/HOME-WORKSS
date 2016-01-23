using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMEWORK
{

    interface ISquareCalculatable
    {
        double Area();
    }
    class Rectangle : ISquareCalculatable
    {

        public override string ToString()
        {
            string template = "width:{0} height:{1} area:{2}";
            return string.Format(template, width.ToString(), height, Area());
        }

        private double height;
        private double width;

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("negative or zero value is passed");
                }

                width = value;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("negative or zero value is passed");
                }

                height = value;
            }
        }
        public double Area()
        {
            return height * width;
        }
    }


    class Triangle : ISquareCalculatable
    {
        public override string ToString()
        {
            string template = "first:{0} second:{1}  third:{2} area:{3}";
            return string.Format(template, first, second, third, Area());
        }
        private double first;
        private double second;
        private double third;
        public double First
        {
            get
            {
                return first;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("negative or zero value is passed");
                }
                first = value;
            }
        }
        public double Second
        {
            get
            {
                return second;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("negative or zero value is passed");
                }
                second = value;
            }
        }
        public double Third
        {
            get
            {
                return third;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("negative or zero value is passed");
                }

                third = value;
            }
        }
        public double Area()
        {
            double p = (first + second + third) / 2;
            return Math.Sqrt(p * (p - first) * (p - second) * (p - third));
        }
    }

    class Circle : ISquareCalculatable
    {
        public override string ToString()
        {
            string template = "radius:{0} area:{1}";
            return string.Format(template, radius, Area());
        }
        private double radius;

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("negative or zero value is passed");
                }

                radius = value;
            }
        }
        public double Area()
        {
            return Math.PI * radius * radius;
        }
    }


    class Square : ISquareCalculatable
    {
        public override string ToString()
        {
            string template = "side:{0} area:{1}";
            return string.Format(template, side, Area());
        }
        private double side;

        public double Side
        {
            get
            {
                return side;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("negative or zero value is passed");
                }
                side = value;
            }
        }
        public double Area()
        {
            return side * side;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Rectangle r = new Rectangle();
                r.Height = 10;
                r.Width = 10;
                Console.WriteLine(r.Area());
                Console.WriteLine(r.ToString());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}

