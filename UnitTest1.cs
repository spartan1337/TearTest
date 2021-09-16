using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace TearTest
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void openBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            string url = "https://testing.todorvachev.com";
            driver.Navigate().GoToUrl(url);
        }

        [Test]
        public void Test1()
        {
            Thread.Sleep(1500);
            driver.FindElement(By.LinkText("ID")).Click();

            string id_title = driver.Title;
            Console.WriteLine(id_title);
            Assert.AreEqual(id_title, "ID – Selenium WebDriver with C#");
           //Assert.Pass();

        }


        [Test]
        public void Test2()
        {
            Thread.Sleep(1500);
            driver.FindElement(By.LinkText("Name")).Click();

            string id_title = driver.Title;
            Assert.AreEqual(id_title, "ID – Selenium WebDriver with C#");
        }
        /*
        [Test]
        public void Test3()
        {
            string url = "https://testing.todorvachev.com";
            driver.Navigate().GoToUrl(url);
            Assert.Pass();
        }*/

        [TearDown]

        public void closebrowser()
        {
            driver.Close();
        }

