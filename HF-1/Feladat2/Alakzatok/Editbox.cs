using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controls;

namespace Shape.Library
{
    public class Editbox : Textbox, IShape
    {
        private BaseShape bs;
        public Editbox(int x, int y, int w, int h) : base(x, y, w, h) 
        {
        //    bs = new BaseShape(x, y);
        }

        public string GetType()
        {
            return typeof(Editbox).ToString();
        }
        public int Height 
        {
            get { return this.GetHeight(); }
        }
        public int Width 
        {
            get { return this.GetWidth(); }
        }

        public double GetArea()
        {
            return Height * Width;
        }

        public string GetInfo()
        {
            return String.Format("{0} x:{1} y:{2} area:{3}", GetType(), this.GetX(), this.GetY(), GetArea());
        }
    }
}
