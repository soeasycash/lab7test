using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using static System.Net.WebRequestMethods;

namespace testsite
{
    [TestFixture]
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();

        [TestCase]
        public void ContactUs()
        {
            driver.Url = "https://www.globalsqa.com/";
            IWebElement button = driver.FindElement(By.XPath("/html/body/div[1]/header/div[2]/div/div/div[3]/div/ul/li[5]/a"));
            button.Click();
            IWebElement login = driver.FindElement(By.XPath("/html/body/div/header/div[2]/div/div/div[3]/div/ul/li[5]/a"));
            login.Click();
            IWebElement name = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[1]/div/form/p[1]/input"));
            name.SendKeys("nowiev");
            IWebElement email = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[1]/div/form/p[2]/input"));
            email.SendKeys("nowiev212321321@mail.ru");
            IWebElement subject = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[1]/div/form/p[3]/input"));
            subject.SendKeys("123123");
            IWebElement message = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[1]/div/form/p[4]/textarea"));
            message.SendKeys("matvey krut");
            IWebElement send = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[1]/div/form/p[5]/input"));
            send.Click();
        }
        [TestCase]
        public void Search()
        {
            driver.Url = "https://www.globalsqa.com/";
            IWebElement search = driver.FindElement(By.XPath("/html/body/div[1]/header/div[1]/div/div/div/div/div[1]/form/input"));
            search.SendKeys("hello");
            IWebElement searchButton = driver.FindElement(By.XPath("/html/body/div/header/div[1]/div/div/div/div/div[1]/form/button"));
            searchButton.Click();
        }
        [TestCase] 
        public void CheatSheets()
        {
            driver.Url = "https://www.globalsqa.com/";
            IWebElement CheatSheets = driver.FindElement(By.XPath("/html/body/div/header/div[2]/div/div/div[3]/div/ul/li[2]/a"));
            CheatSheets.Click();
        }
        [TestCase]
        public void Pinterest()
        {
            driver.Url = "https://www.globalsqa.com/";
            IWebElement pinterest = driver.FindElement(By.XPath("/html/body/div/header/div[1]/div/div/div/div/a[1]"));
            pinterest.Click();
        }
        [TestCase]
        public void IW2()
        {
            driver.Url = "https://www.globalsqa.com/";
            IWebElement iw2 = driver.FindElement(By.XPath("/html/body/div/div[1]/div/div[3]/div/div/div/div[2]/div[2]/div[3]/a/img"));
            iw2.Click();
        }
    }
}