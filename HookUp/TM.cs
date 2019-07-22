using System;
using ICTest.Helpers;
using ICTest.Pages;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace ICTest.Feature
{
    [Binding]
    public class TM
    {
        [Given("I have logged in to time and material page successfully")]
        public void login()
        {
            
            CommonDrivers.driver = new ChromeDriver(Environment.CurrentDirectory);

            //login action
            Login loginobj = new Login();
            loginobj.Loginsteps(CommonDrivers.driver);
        }

        [Given("I have navigated to TM page")]
        public void NavigateToTM()
        {

            //Navigate to TM
            Home homeobj = new Home();
            homeobj.NavigateTM(CommonDrivers.driver);
        }

        [Then("I should be able to create new material with valid details successfully")]
        public void Create()
        {
            
            //create new TM
            CreateTM createobj = new CreateTM();
            createobj.Create(CommonDrivers.driver);

        }
    }
}
