using LatinWords;
using SentenceGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RandomLatinTests
{
    [TestClass]
    public class SentenceTests
    {
        [TestMethod]
        public void CreateNominativeReturnsNominativeNoun()
        {
            Noun sut = new Noun();
            NounGenerator sut2 = new NounGenerator();

            sut = sut2.CreateNominative();

            Assert.AreEqual(sut.Case, "nominative");
        }
        [TestMethod]
        public void CreateNominativeGeneratesRandomNumber()
        {
            Noun sut = new Noun();
            NounGenerator sut2 = new NounGenerator();

            sut = sut2.CreateNominative();

            Assert.IsTrue(sut.Number == "singular" || sut.Number == "plural");
        }
    }
}
