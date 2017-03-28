using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shape.Library;

namespace Feladat2
{
    public class Class1
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>();

            shapes.Add(new Circle(2, 3, 5));
            shapes.Add(new Square(5, 6, 11));
            shapes.Add(new Editbox(7, 7, 10, 10));


            foreach (var item in shapes)
            {
                Console.WriteLine(item.GetInfo());
            }

            Console.ReadKey();
        }
    }
}
