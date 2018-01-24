using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace SolutionsTests
{
    [TestFixture]
    [Category("UITests")]
    public class UiUsingSeleniumTest
    {
        [Test]
        public void TestA()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.demoqa.com";

            Assert.IsTrue(driver.Title == "Demoqa | Just another WordPress site");
            Thread.Sleep(1000);
            driver.Close();
        }

        [Test]
        public void TestB()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.demoqa.com";

            Assert.IsTrue(driver.Title == "Demoqa | Just another WordPress site");
            Thread.Sleep(1000);
            driver.Close();
        }
    }
}
