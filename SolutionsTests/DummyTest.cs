using NUnit.Framework;
using TestVisualStudioOnline;

namespace SolutionsTests
{
    [TestFixture]
    public class DummyTest
    {
        [Test]
        public void Hello_WhenInputIsJippe_ShouldReturnHelloJippi()
        {
            var whatToTest = new Dummy();

            var result = whatToTest.Hello("Jippi");

            Assert.AreEqual(result, "Hello Jippi");
        }
    }
}
