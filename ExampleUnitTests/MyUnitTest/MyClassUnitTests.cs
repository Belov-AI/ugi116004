using NUnit.Framework;
using ExampleUnitTests;

namespace MyUnitTest
{
    [TestFixture]
    public class MyClassUnitTests
    {
        

        [Test]
        public void TestConstrucnor()
        {
            var obj = new MyClass("Hello");
            Assert.AreEqual("Hello", obj.Description);
        }
    }
}