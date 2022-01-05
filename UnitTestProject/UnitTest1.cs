using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver WebDriver;

        [TestMethod]
        public void Test1_field()
        {
            var options = new ChromeOptions();
            options.AddExcludedArgument("enable-loggin");
            options.AddArguments("--headless");
            WebDriver = new ChromeDriver(@"C:\Users\Ervins\source\repos\DuhhTOR\Exam2021rudens\WebDrivers", options);
            WebDriver.Url = "https://www.ebay.com/";

            Assert.IsTrue(WebDriver.PageSource.Contains("gh-ac"));
        }
        

        [TestMethod]
        public void Test2_search()
        {
            var options = new ChromeOptions();
            options.AddExcludedArgument("enable-loggin");
            options.AddArguments("--headless");
            WebDriver = new ChromeDriver(@"C:\Users\Ervins\source\repos\DuhhTOR\Exam2021rudens\WebDrivers", options);
            WebDriver.Url = "https://www.ebay.com/";

            Assert.IsTrue(WebDriver.PageSource.Contains("gh-btn"));
        }
    }
}
