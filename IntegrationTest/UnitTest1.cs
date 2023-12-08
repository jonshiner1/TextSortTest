

using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleTest;

namespace IntegrationTest
{
    [TestClass]
    public class UnitTest1
    {
        private ConsoleLogger logger = new ConsoleLogger();

        [TestMethod]
        public void WordSort()
        {        
            Assert.AreEqual("Boom Zoom", SimpleTest.MyTest.CalculateTotal("Zoom Boom", logger));
        }

        [TestMethod]
        public void CaseSort()
        {        
            Assert.AreEqual("Boom boom", SimpleTest.MyTest.CalculateTotal("boom Boom", logger));
        }

        [TestMethod]
        public void RemoveFullstop()
        {
            Assert.AreEqual("b b", SimpleTest.MyTest.CalculateTotal("b. b", logger));
        }

        [TestMethod]
        public void RemoveComma()
        {
            Assert.AreEqual("b b", SimpleTest.MyTest.CalculateTotal("b, b", logger));
        }

        [TestMethod]
        public void RemoveSingleQuote()
        {
            Assert.AreEqual("b b", SimpleTest.MyTest.CalculateTotal("b' b", logger));
        }

        [TestMethod]
        public void RemoveSemicolon()
        {
            Assert.AreEqual("b b", SimpleTest.MyTest.CalculateTotal("b; b", logger));
        }

        [TestMethod]
        public void SimpleTest1()
        {        
            Assert.AreEqual("baby Go go", SimpleTest.MyTest.CalculateTotal("Go baby, go", logger));
        }

        [TestMethod]
        public void SimpleTest2()
        {
            Assert.AreEqual("ABC aBc abc CBA CBA cba", SimpleTest.MyTest.CalculateTotal("CBA, abc aBc ABC cba CBA.", logger));
        }
    }
}