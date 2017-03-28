using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Library
{
    public class Square : BaseShape
    {
        public Square(int x, int y) : base(x, y) { }

        public Square(int x, int y, int s)
            : base(x, y)
        {
            Side = s;
        }
        public int Side {get; set;}

        public override double GetArea()
        {
            return Side * Side;
        }
    }
}
