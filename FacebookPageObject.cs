using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumFacebookTest
{
	public class FacebookPageObject
	{
		




		//go to page
		public static void goToHomePage(FirefoxDriver driver)
		{
			driver.Navigate ().GoToUrl ("http://www.facebook.com");
		}

		//check for login
		public static Boolean checkForLogin(FirefoxDriver driver)
		{
			if (driver.FindElements (By.Id ("email")) > 0)
				return true;
			return false;
		}


		//log in
		public static void logIn(FirefoxDriver driver)
		{
			if (checkForLogin (driver))
				logOut(driver);

			Console.WriteLine ("Please enter your email address");
			FirefoxWebElement email = driver.FindElementById ("email");
			email.Click ();
			email.SendKeys (Console.ReadLine ());

			Console.WriteLine ("Please enter your password");
			FirefoxWebElement password = driver.FindElementById ("pass");
			password.Click ();
			password.SendKeys (Console.ReadLine ());

			password.SendKeys(Keys.Enter);
		}

		//log out
		public static void logOut(FirefoxDriver driver)
		{
			if (checkForLogin (driver)) {
				driver.FindElementById ("userNavigationLabel").Click();
				driver.FindElementByXPath ("/html/body/div[2]/div/div/div/div/div[1]/div/div/ul/li[12]/a/span/span").Click ();
				return;
			}
			return false;

		}

		//post status
		//to do

		//check element
		//to do

		//set visibility status
		//to do

		//delete status
		//to do
	}
}

