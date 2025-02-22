using EvenOdd;

namespace TestNumber
{

    [TestFixture]

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Even()
        {
            string expected = "Even";
            Check p = new Check();
            string actual = p.EvenOrOdd(10);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Odd()
        {
            string expected = "Odd";
            Check p = new Check();
            string actual = p.EvenOrOdd(11);
            Assert.AreEqual(expected, actual);

        }
    }
}