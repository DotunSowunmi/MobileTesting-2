using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;

namespace GiftreteMobileApp
{


    [TestClass]
    public class AppTest
    {



        //AndroidDriver<IWebElement> driver;
        //////IOSDriver<IWebElement> driver;
        AppiumDriver<IWebElement> driver;

        [TestMethod]
        public void TestMethod()
        {

            // setup desired capability
            AppiumOptions cap = new AppiumOptions();

            cap.AddAdditionalCapability("deviceName", "SM 950F");
            cap.AddAdditionalCapability("PlatformName", "Android");
            cap.AddAdditionalCapability("PlatformVersion", "9.0");
            cap.AddAdditionalCapability("udid", "ce08171893f2cf0c057e");
            cap.AddAdditionalCapability("appPackage", "gift.giftrete.com");
            cap.AddAdditionalCapability("appActivity", "gift.giftrete.com.SplashScreenActivity");
            cap.AddAdditionalCapability("newCommandTimeout", 1000);
            cap.AddAdditionalCapability("launchTimeout", 100000);

            

            // set up the url for appium server to launch the automation session


            driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);

            // driver = new AndroidDriver<IWebElement>(new Uri("http://0.0.0.0:4723/wd/hub"), cap);

            // gather element for writing tests


            // driver.FindElementById("email").SendKeys("yinkaland");
            // driver.FindElementById("password").SendKeys("yinka1969");
            // driver.FindElementById("button").Click();



        }
    }
}
