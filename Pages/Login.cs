using System;
using OpenQA.Selenium;

namespace ICTest.Pages
{
    public class Login
    {
        public void Loginsteps(IWebDriver driver)
        {
            //launch chrome driver
            //IWebDriver driver = new OperaDriver(Environment.CurrentDirectory);
            //IWebDriver driver = new ChromeDriver(Environment.CurrentDirectory);

            //maximise browser
            driver.Manage().Window.Maximize();

            //launch website
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login");

            //enter username
            IWebElement Username = driver.FindElement(By.Id("UserName"));
            Username.SendKeys("hari");
            //enter password
            IWebElement Password = driver.FindElement(By.Id("Password"));
            Password.SendKeys("123123");
            //login button
            IWebElement Login = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            Login.Click();
            //validate if user has logged in successfully
            IWebElement success = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if (success.Text == ("Hello hari!"))
            {
                Console.WriteLine("Log in successful, Login test passed");
            }
            else
            {
                Console.WriteLine("Login failed,Test failed");

            }

        }
    }
}
