using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat1
{
    class Song
    {
        public readonly string szerzo;
        public readonly string cim;

        public Song(string szerzo, string cim)
        {
            // TODO: Complete member initialization
            this.szerzo = szerzo;
            this.cim = cim;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}",szerzo,cim);
        }
    }
}
