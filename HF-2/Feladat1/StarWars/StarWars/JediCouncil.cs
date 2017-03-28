using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    public delegate void Notification(string message);
    
    public class JediCouncil
    {
        public event Notification CouncilChanged;

        private List<Jedi> members = new List<Jedi>();

        public int Count
        {
            get { return members.Count; }
        }

        public void Add(Jedi newJedi)
        {
            members.Add(newJedi);
            if (CouncilChanged != null)
                CouncilChanged(String.Format("Új taggal ({0}) bővültünk", newJedi.Name));
        }

        public void Remove()
        {
            this.RemoveAt(0);
        }

        private void RemoveAt(int index)
        {
            if(index >= members.Count)
                throw new Exception("Nincs ilyen indexű Jedi");

            members.RemoveAt(index);

            if (CouncilChanged == null)
                return;

            if (members.Count > 0)
                CouncilChanged("Zavart érzek az Erőben");
            else
                CouncilChanged("A tanács elesett!");
        }

        public List<Jedi> GetBeginners()
        {
            List<Jedi> beginners = new List<Jedi>();
            beginners = members.FindAll(j => j.MidiChlorianCount < 5000);

            return beginners;
        }

        public int CountIf(Func<Jedi, bool> cond)
        {
            return members.Count(cond);
        }
    }
}
