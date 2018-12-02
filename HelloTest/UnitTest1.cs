using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace HelloTest
{
    [TestClass]
    public class UnitTestJenkins
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello World", Hello.Program.CreateMessage());
        }
    }
}
 