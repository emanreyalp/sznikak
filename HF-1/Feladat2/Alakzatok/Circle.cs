using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Library
{
    public class Circle : BaseShape
    {
        public Circle(int x, int y) : base(x, y) { }

        public Circle(int x, int y, int r) : base(x, y)
        {
            R = r;
        }


        public int R { get; set; }

        public override double GetArea()
        {
            double area = R * R * 3.14;
            return area;
        }
    }
}
