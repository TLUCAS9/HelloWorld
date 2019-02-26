using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldProcessor;

namespace HelloWorldUnitTest
{
    [TestClass]
    public class HelloWorldTest
    {

        [TestMethod]
        public void TestInputString()
        {
            string helloGoodTest = "Hello World";
            Assert.AreEqual(helloGoodTest, HelloWorldModel.HelloWorld);
          
            string helloBadInputTest = "Hello xxWorld";
            Assert.AreNotEqual(helloBadInputTest, HelloWorldModel.HelloWorld);
        }

        [TestMethod]
        public void TestConsoleOutput()
        {
            HelloWorldToConsole testConsole = new HelloWorldToConsole();
            bool testOK = testConsole.WriteHelloWorld();
            Assert.IsTrue(testOK);
        }

        [TestMethod]
        public void TestDatabaseOutput()
        {
            HelloWorldToDatabase testDatabase = new HelloWorldToDatabase();
            bool testOK = testDatabase.WriteHelloWorld();
            Assert.IsTrue(testOK);
        }

        [TestMethod]
        public void TestFileOutput()
        {
            HelloWorldToFile testFile = new HelloWorldToFile();
            bool testOK = testFile.WriteHelloWorld();
            Assert.IsTrue(testOK);
        }
    }
}
