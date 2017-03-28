using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StarWars
{
    [XmlRoot("Jedi")]
    public class Jedi
    {
        public Jedi() {}
        public Jedi(string name, int mcc)
        {
            Name = name;
            MidiChlorianCount = mcc;
        }

        private int midiChlorianCount;
        
        [XmlAttribute("Nev")]
        public string Name
        { get; set; }

        [XmlAttribute("MinidkoliranErtek")]
        public int MidiChlorianCount
        {
            get 
            {
                return midiChlorianCount;
            }
            set
            { 
                if(value <= 0)
                    throw new ArgumentException("You are not a true jedi!");

                midiChlorianCount = value;
            }
        }
    }
}
