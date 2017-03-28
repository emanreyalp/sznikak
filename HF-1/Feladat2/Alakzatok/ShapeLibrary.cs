using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Library
{
    public interface IShape
    {
        int GetX();
        int GetY();
        double GetArea();
        string GetInfo();

    }
    public abstract class BaseShape : IShape
    {
        private int x;
        private int y;
        public BaseShape(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public abstract double GetArea();

        public string GetInfo()
        {
            return String.Format("{0} x:{1} y:{2} area:{3}", GetType(), x, y, GetArea());
        }

    }
}
