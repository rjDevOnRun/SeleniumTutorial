using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get WebDriver Object of the browser
            // Download respective drivers as needed.
            // careful about the versions of the driver
            //  and the browser version on your machine.

            // USING FIREFOX
            //IWebDriver driver = new FirefoxDriver();
            //driver.Url = "http://facebook.com"; // Add the Url to viist on browser
            
            // USING CHROME
            IWebDriver driver = new ChromeDriver(@"D:\DEVELOPMENT\RJGitRepository\SeleniumTutorial\chromedriver_win32 _78.0105");
            driver.Navigate().GoToUrl("http://facebook.com"); // Add the Url to viist on browser
                       
            // Maximize the browser window
            driver.Manage().Window.Maximize();
            // Wait for browser to load page/url fully.. wait 10 sec..
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // SendKeys to UID / PWD textboxes and login.
            driver.FindElement(By.Name("email")).SendKeys("john.roby76@gmail.com");
            driver.FindElement(By.Name("pass")).SendKeys("xxxxxxxxxxxxxxxxxxxx" + Keys.Enter);

        }
    }
}
