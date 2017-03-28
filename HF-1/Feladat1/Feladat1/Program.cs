using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Feladat1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> zenek = new List<Song>();

            //fájlbeolvasás
            StreamReader fbe = null;
            try
            {
                fbe = new StreamReader("music.txt");

                while (fbe.Peek() >= 0)
                {
                    string str;
                    string[] strArray;
                    str = fbe.ReadLine();

                    strArray = str.Split(';');

                    for (int i = 1; i < strArray.Length; i++)
                        zenek.Add(new Song(strArray[0].Trim(), strArray[i].Trim()));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Hibás fájlfeldolgozás! \n" + e.Message);
            }
            finally
            {
                if (fbe != null)
                    fbe.Close();
            }
            foreach(Song a in zenek)
            {
                Console.WriteLine(a.ToString());
            }
            Console.ReadKey();
        }
    }
}
