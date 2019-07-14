using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OpenQA.Selenium;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Chrome;
using ICTest.Pages;
using ICTest.Helpers;
using NUnit.Framework;

namespace ICTest
{
    [TestFixture]
    public class Program
    {
        
        [SetUp]
        public void Login()
        {
            //define drivers
            CommonDrivers.driver = new ChromeDriver(Environment.CurrentDirectory);

            //login action
            Login loginobj = new Login();
            loginobj.Loginsteps(CommonDrivers.driver);

            //Navigate to TM
            Home homeobj = new Home();
            homeobj.NavigateTM(CommonDrivers.driver);

        }
        [Test]
        public void Create()
        {

            //create new TM
            CreateTM createobj = new CreateTM();
            createobj.Create(CommonDrivers.driver);

        }
        [Test]
        public void Edit()
        {
            //Edit TM
            CreateTM editobj = new CreateTM();
            editobj.Edit(CommonDrivers.driver);
        }

        [Test]
        public void Del()
        {
            //Delete TM
            CreateTM delobj = new CreateTM();
            delobj.Del(CommonDrivers.driver);
        }


        [TearDown]
        public void Close()
        {
            CommonDrivers.driver.Quit();
        }

    }
       
    }

