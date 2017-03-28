using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Library.Test
{
    [TestFixture]
    public class JedisTest
    {
        [Test]
        public void TestNameIsSaved([Values("Yoda", "Luke")] string name)
        {
            Jedi j = new Jedi();

            j.Name = name;
            Assert.AreEqual(name, j.Name);
        }

        [Test]
        public void TestMCCIsSaved([Values(1,2,100)] int mCC)
        {
            Jedi j = new Jedi();

            j.MidiChlorianCount = mCC;
            Assert.AreEqual(mCC, j.MidiChlorianCount);

        }

        [Test]
        public void TestNowExceptionIsThrowByMCC([Values(0,-1,-2,-10)] int mCC)
        {
            Jedi j = new Jedi();

            try
            {
                j.MidiChlorianCount = mCC;
                Assert.Fail("Not throw exception but expected");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("You are not a true jedi!", ex.Message);
            }
        }

        [Test]
        public void TestNowExceptionIsNotTrowByMCC([Values(1,2,10)] int MCC)
        {
            Jedi j = new Jedi();

            try
            {
                j.MidiChlorianCount = MCC;
                Assert.Pass("Not throw exception and that's good");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Not throw exception and that's good", ex.Message);
            }
        }
    }
}
