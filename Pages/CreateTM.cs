using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ICTest.Pages
{
    public class CreateTM
    {
        public void Create(IWebDriver driver)
        {
            //create new page

            //click on create new button
            IWebElement create = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            create.Click();

            //select type code
            IWebElement type = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span"));
            type.Click();
            //select time
            IWebElement t = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            t.Click();

            //enter code
            IWebElement code = driver.FindElement(By.XPath("//*[@id='Code']"));
            code.SendKeys("A1");
            //enter description
            IWebElement desc = driver.FindElement(By.XPath("//*[@id='Description']"));
            desc.SendKeys("testdesc");
            //enter price
            try
            {
                IWebElement price = driver.FindElement(By.XPath("//*[@id='Price']"));
                price.SendKeys("25");
            }
            catch (Exception e)
            {
                Console.WriteLine("Element not interactable" + e);
            }
            

            //click on save
            IWebElement save = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            save.Click();
            //click to last page
            Thread.Sleep(1000);
            IWebElement lp = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lp.Click();
            //verify existence of new record
            IWebElement su = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[2]/td[1]"));
            if (su.Text == "A1")
            {
                Console.WriteLine("Record created successfully, Test Passed");
            }
            else
            {
                Console.WriteLine("Test failed");
            }
        }

        public void Edit(IWebDriver driver)
        {
            //edit button

            Thread.Sleep(1000);
            //click on edit button
            IWebElement edit = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[1]"));
            edit.Click();
            

            //enter code
            IWebElement code = driver.FindElement(By.XPath("//*[@id='Code']"));
            code.SendKeys("A1");
            //enter description
            IWebElement desc = driver.FindElement(By.XPath("//*[@id='Description']"));
            desc.SendKeys("testdesc");

            //enter price
            try
            {
                IWebElement price = driver.FindElement(By.XPath("//*[@id='Price']"));
                price.SendKeys("25");
            }
            catch (Exception e)
            {
                Console.WriteLine("Element not interactable" + e);
            }


            //click on save
            IWebElement save = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            save.Click();



        }
        public void Del(IWebDriver driver)
        {
            Thread.Sleep(1000);

            IWebElement delete = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[2]"));
            delete.Click();

            driver.SwitchTo().Alert().Accept();
        }
    }
}
