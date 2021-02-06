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
            NounInstance sut = new NounInstance();
            NounGenerator sut2 = new NounGenerator();

            sut = sut2.CreateNominativeNoun();

            Assert.AreEqual(sut.Case, Case.Nominative);
        }
        [TestMethod]
        public void CreateNominativeGeneratesRandomGender()
        {
            NounInstance sut = new NounInstance();
            NounGenerator sut2 = new NounGenerator();

            sut = sut2.CreateNominativeNoun();

            Assert.IsTrue(sut.Gender == Gender.Masculine || sut.Gender == Gender.Feminine || sut.Gender == Gender.Neuter);
        }
        [TestMethod]
        public void CreateNominativeGeneratesRandomGenderNumeric()
        {
            NounInstance sut = new NounInstance();
            NounGenerator sut2 = new NounGenerator();

            sut = sut2.CreateNominativeNoun();

            Assert.IsTrue((int) sut.Gender >= 0 && (int) sut.Gender < 3);
        }
        [TestMethod]
        public void CreateNominativeGeneratesRandomNumber()
        {
            NounInstance sut = new NounInstance();
            NounGenerator sut2 = new NounGenerator();

            sut = sut2.CreateNominativeNoun();

            Assert.IsTrue(sut.Number == Number.Singular || sut.Number == Number.Plural);
        }
    }
}
