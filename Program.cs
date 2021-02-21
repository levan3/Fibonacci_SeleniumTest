using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Selenium
{
    class Program
    {
        //Create REference for the browsr
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
            


        }

        [OneTimeSetUp]
        public void Initialize()
        {
            //Navigate to Calculation URL
            driver.Navigate().GoToUrl("http://fibonaccicalculator.com.s3-website-ap-southeast-2.amazonaws.com/");
        }

       [Test]
        public void TestCase1()
        {
            //Find page Element and input value
            IWebElement element = driver.FindElement(By.Id("position"));
            element.SendKeys("4");

            //Click Button
            IWebElement submit_button = driver.FindElement(By.Id("reveal"));
            submit_button.Click();

            //Verify Result
            IWebElement ActualResult = driver.FindElement(By.Id("answer2"));
            String StringResult = ActualResult.Text;
            String ExpectedResult = "3";
            Assert.AreEqual(StringResult, ExpectedResult);
            //Assert.AreEqual(ActualResult.Text, "3");
      

            //Delete typed input or Refresh
            element.Clear();
        }

        [Test]
        public void TestCase2()
        {
            //Find page Element and input value
            IWebElement element = driver.FindElement(By.Id("position"));
            element.SendKeys("12");

            //Click Button
            IWebElement submit_button = driver.FindElement(By.Id("reveal"));
            submit_button.Click();

            //Verify Result
            IWebElement ActualResult = driver.FindElement(By.Id("answer2"));
            String StringResult = ActualResult.Text;
            String ExpectedResult = "144";
            Assert.AreEqual(StringResult, ExpectedResult);
            //Assert.AreEqual(ActualResult.Text, "3");


            //Delete typed input or Refresh
            element.Clear();
        }

        [Test]
        public void TestCase3()
        {
            //Find page Element and input value
            IWebElement element = driver.FindElement(By.Id("position"));
            element.SendKeys("50");

            //Click Button
            IWebElement submit_button = driver.FindElement(By.Id("reveal"));
            submit_button.Click();

            //Verify Result
            IWebElement ActualResult = driver.FindElement(By.Id("answer2"));
            String StringResult = ActualResult.Text;
            String ExpectedResult = "12586269025";
            Assert.AreEqual(StringResult, ExpectedResult);
            


            //Delete typed input or Refresh
            element.Clear();
        }

        [Test]
        public void TestCase4()
        {
            //Find page Element and input value
            IWebElement element = driver.FindElement(By.Id("position"));
            element.SendKeys("100");

            //Click Button
            IWebElement submit_button = driver.FindElement(By.Id("reveal"));
            submit_button.Click();

            //Verify Result
            IWebElement ActualResult = driver.FindElement(By.Id("answer2"));
            String StringResult = ActualResult.Text;
            String ExpectedResult = "354224848179261915075";
            Assert.AreEqual(StringResult, ExpectedResult);



            //Delete typed input or Refresh
            element.Clear();
        }

        [Test]
        public void TestCase5()
        {
            //Find page Element and input value
            IWebElement element = driver.FindElement(By.Id("position"));
            element.SendKeys("Hello");

            //Click Button
            IWebElement submit_button = driver.FindElement(By.Id("reveal"));
            submit_button.Click();

            //Verify Result
            IWebElement ActualResult = driver.FindElement(By.Id("answer2"));
            String StringResult = ActualResult.Text;
            String ExpectedResult = null;
            Assert.AreEqual(StringResult, ExpectedResult);



            //Delete typed input or Refresh
            element.Clear();
        }

        [Test]
        public void TestCase6()
        {
            //Find page Element and input value
            IWebElement element = driver.FindElement(By.Id("position"));
            element.SendKeys("Hello123");

            //Click Button
            IWebElement submit_button = driver.FindElement(By.Id("reveal"));
            submit_button.Click();

            //Verify Result
            IWebElement ActualResult = driver.FindElement(By.Id("answer2"));
            String StringResult = ActualResult.Text;
            String ExpectedResult = null;
            Assert.AreEqual(StringResult, ExpectedResult);



            //Delete typed input or Refresh
            element.Clear();
        }

        [Test]
        public void TestCase7()
        {
            //Find page Element and input value
            IWebElement element = driver.FindElement(By.Id("position"));
            element.SendKeys("4.53");

            //Click Button
            IWebElement submit_button = driver.FindElement(By.Id("reveal"));
            submit_button.Click();

            //Verify Result
            IWebElement ActualResult = driver.FindElement(By.Id("answer2"));
            String StringResult = ActualResult.Text;
            String ExpectedResult = null;
            Assert.AreEqual(StringResult, ExpectedResult);



            //Delete typed input or Refresh
            element.Clear();
        }

        [Test]
        public void TestCase8()
        {
            //Find page Element and input value
            IWebElement element = driver.FindElement(By.Id("position"));
            element.SendKeys("-5");

            //Click Button
            IWebElement submit_button = driver.FindElement(By.Id("reveal"));
            submit_button.Click();

            //Verify Result
            IWebElement ActualResult = driver.FindElement(By.Id("answer2"));
            String StringResult = ActualResult.Text;
            String ExpectedResult = null;
            Assert.AreEqual(StringResult, ExpectedResult);



            //Delete typed input or Refresh
            element.Clear();
        }

        [OneTimeTearDown]
        public void Teardown()
        {
            driver.Close();
        }
    }
}
