using System;
using OpenQA.Selenium;

namespace ICTest.Pages
{
    public class Home
    {
        public void NavigateTM(IWebDriver driver)
        {
            //navigate to create new page
            //click on administration
            IWebElement admin = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            admin.Click();
            //click on time and material
            IWebElement time = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            time.Click();
        }
    }
}
