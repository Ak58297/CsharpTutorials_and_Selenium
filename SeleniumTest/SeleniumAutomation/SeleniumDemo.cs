using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumAutomation
{
    public class SeleniumDemo
    {
        IWebDriver driver;
        [SetUp]
        public void InvokeBrowser()
        {
            //new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            //driver = new ChromeDriver();
            //driver = new FirefoxDriver();
            driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
          //  driver.Manage().Timeouts().ImplicitWait= TimeSpan.FromSeconds(3);
            driver.Url = "https://www.google.com/";
        }

        [Test]
        public void googleTitleTest ()
        {
            TestContext.Progress.WriteLine(driver.Url);
            TestContext.Progress.WriteLine(driver.Title);
            TestContext.Progress.WriteLine(driver.FindElement(By.XPath("//div[text()='India']")).Text);           
        }

        [Test]
        public void QAdemoTest()
        {
            driver.FindElement(By.XPath("//*[@title='Search']")).SendKeys("https://demoqa.com/");
            driver.FindElement(By.XPath("//*[@title='Search']")).SendKeys(Keys.Enter);
            String Link = driver.FindElement(By.XPath("//*[text()='Demo QA']")).Text;
            WebDriverWait wait=new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElement
                (driver.FindElement(By.XPath("//*[text()='Demo QA']")), Link));

            Assert.AreEqual(Link, "Demo QA");
            driver.FindElement(By.XPath("//*[text()='Demo QA']")).Click();
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
