using StarWars;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StarWarsConsole
{
    class Program
    {
        static void MessageReceived(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            // Tanács létrehozása
            JediCouncil council = new JediCouncil();
            council.CouncilChanged += MessageReceived;

            Jedi jedi0 = new Jedi();
            jedi0.Name = "Luke";
            jedi0.MidiChlorianCount = 15000;
            council.Add(jedi0);

            XmlSerializer serializer = new XmlSerializer(typeof(Jedi));
            FileStream fileStreamOut = new FileStream("jedi.txt", FileMode.Create);
            serializer.Serialize(fileStreamOut, jedi0);
            fileStreamOut.Close();

            // Tanács feltöltése 2 taggal
            Jedi jedi1 = new Jedi();
            jedi1.Name = "Yoda";
            jedi1.MidiChlorianCount = 17000;
            council.Add(jedi1);
            council.Add(new Jedi("Jedi baby", 200));
            council.Add(new Jedi("Jedi boy", 2800));

            council.Remove();

            int sth = council.CountIf(delegate(Jedi j) { return j.MidiChlorianCount > 2; });
            Console.WriteLine(" ## {0} ##", sth);

            Jedi jedi2 = new Jedi();
            jedi2.Name = "Anakin Skywalker";
            jedi2.MidiChlorianCount = 27000;
            council.Add(jedi2);

            foreach (var j in council.GetBeginners())
            {
                Console.WriteLine("{0} : {1}", j.Name, j.MidiChlorianCount);
            }

            council.Remove();
            council.Remove();
            council.Remove();
            council.Remove();
           // 
            //j.MidiChlorianCount = 0;

           

            //Process.Start("jedi.txt");
            
            serializer = new XmlSerializer(typeof(Jedi));
            FileStream fileStreamIn = new FileStream("jedi.txt", FileMode.Open);
            Jedi clone = (Jedi)serializer.Deserialize(fileStreamIn);
            fileStreamIn.Close();
            Console.WriteLine("{0} : {1}", clone.Name, clone.MidiChlorianCount);

            Console.ReadKey();
        }
    }
}
