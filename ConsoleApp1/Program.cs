using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CustomMethods
{
	class Program
	{

        static void Main(string[] args)
		{

		}

        [SetUp]
        public void Initialize()
        {
            // create the reference for the driver
            PropertiesCollection.driver = new ChromeDriver();

            // navigate to execute automation test site
            PropertiesCollection.driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Opened URL.");
        }

        [Test]
        public void ExecuteTest()
        {
            //Title
            SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);

            //Initial
            SeleniumSetMethods.EnterText("Initial", "executeautomation", PropertyType.Name);

            Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetText("TitleId", PropertyType.Id));

            Console.WriteLine("The value from my Initial is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));

            //Click
            SeleniumSetMethods.Click("Save", PropertyType.Name);
        }

        [Test]
        public void NextTest() => Console.WriteLine("Execute next test.");

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();

            Console.WriteLine("Closed the browser.");
        }
	}
}
