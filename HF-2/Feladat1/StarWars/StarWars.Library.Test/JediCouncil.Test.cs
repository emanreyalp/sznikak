using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Library.Test
{   
    [TestFixture]
    class JediCouncilTest
    {
        [Test]
        public void TestAddJedi()
        {
            JediCouncil jc = new JediCouncil();
            jc.Add(new Jedi("Luke", 5000));

            Assert.AreEqual(1, jc.Count);
        }

        [Test]
        public void TestRemoveJedi()
        {
            JediCouncil jc = new JediCouncil();
            jc.Add(new Jedi("Luke", 5000));

            jc.Remove();
            Assert.AreEqual(0, jc.Count);
        }

        [Test]
        public void TestGetBeginners()
        {
            JediCouncil jc = new JediCouncil();
            jc.Add(new Jedi("LitleLuke", 4000));
            jc.Add(new Jedi("Yoda", 300000));
            jc.Add(new Jedi("LitleAnakin", 3000));

            List<Jedi> beginners = jc.GetBeginners();
            foreach (var j in beginners)
            {
                if (j.MidiChlorianCount > 5000)
                    Assert.Fail("I have a beginner who is not beginner");
            }
            Assert.Pass("They are just beginners");
        }

        [Test]
        public void TestCountIf()
        {
            JediCouncil jc = new JediCouncil();
            jc.Add(new Jedi("LitleLuke", 4000));
            jc.Add(new Jedi("Yoda", 300000));
            jc.Add(new Jedi("LitleAnakin", 3000));

            int ci = jc.CountIf(
                delegate(Jedi j)
                {
                    return j.MidiChlorianCount > 3002;
                });

            Assert.AreEqual(2, ci);
        }

        [Test]
        public void TestAddNewJediEventHandling()
        {
            JediCouncil jc = new JediCouncil();
            Jedi j = new Jedi("Luke", 30000);
            jc.CouncilChanged +=
                delegate(string message)
                {
                    Assert.AreEqual(String.Format("Új taggal ({0}) bővültünk", j.Name),message);
                };
            jc.Add(j);
        }

        [Test]
        public void TestRemoveJediEventHandling()
        {
            JediCouncil jc = new JediCouncil();
            jc.Add(new Jedi("LitleLuke", 4000));
            jc.Add(new Jedi("Luke", 30000));
            jc.CouncilChanged +=
                delegate(string message)
                {
                    Assert.AreEqual(String.Format("Zavart érzek az Erőben"), message);
                };
            jc.Remove();
        }

        [Test]
        public void TestTheCouncilHasFallenEventHandling()
        {
            JediCouncil jc = new JediCouncil();
            jc.Add(new Jedi("LitleLuke", 4000));
            jc.CouncilChanged +=
                delegate(string message)
                {
                    Assert.AreEqual(String.Format("A tanács elesett!"), message);
                };
            jc.Remove();
        }

    }
}
