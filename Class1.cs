using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace lab9
{
    [TestFixture]
    public class Class1
    {
        IWebDriver webDriver = new ChromeDriver();

        [TestCase]
        public void mainTitle1()
        {
            webDriver.Url = "https://www.ects.ru/";
            Assert.AreEqual("Екатеринбургский Колледж Транспортного Строительства", webDriver.Title);
            webDriver.Close();
        }

        [TestCase]
        public void clickButton1()
        {
            webDriver.Url = "https://www.ects.ru/";
            var wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, 15));
            var elem = wait.Until(condition =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(By.XPath("/html/body/center/div/div[4]/table/tbody/tr/td[4]/a"));
                    return element.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch(NoSuchElementException) 
                {
                    return false;                
                }
            });
            IWebElement button = webDriver.FindElement(By.XPath("/html/body/center/div/div[4]/table/tbody/tr/td[4]/a"));   
            button.Click();
            webDriver.Close();
        }

        [TestCase]
        public void isDisplayed1()
        {
            webDriver.Url = "https://www.ects.ru/";
            IWebElement element = webDriver.FindElement(By.XPath("/html/body/center/div/div[4]/table/tbody/tr/td[4]/a"));
            bool status = element.Displayed;
            Assert.IsTrue(status);
            webDriver.Close();
        }

        [TestCase]
        public void url1()
        {
            webDriver.Url = "https://www.ects.ru/";
            var wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, 15));
            var elem = wait.Until(condition =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(By.XPath("/html/body/center/div/div[4]/table/tbody/tr/td[4]/a"));
                    return element.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
            IWebElement button = webDriver.FindElement(By.XPath("/html/body/center/div/div[4]/table/tbody/tr/td[4]/a"));
            button.Click();
            webDriver.Navigate().Back();
            webDriver.Close();
        }

        [TestCase]
        public void mainTitle2()
        {
            webDriver.Url = "https://www.youtube.com/";
            Assert.AreEqual("YouTube", webDriver.Title);
            webDriver.Close();
        }

        [TestCase]
        public void isDisplayed2()
        {
            webDriver.Url = "https://www.youtube.com/";
            var wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, 15));
            var elem = wait.Until(condition =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(By.XPath("/html/body/ytd-app/div[1]/div/ytd-masthead/div[4]/div[1]/ytd-topbar-logo-renderer/a/div/ytd-logo/yt-icon/yt-icon-shape/icon-shape/div"));
                    return element.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
            webDriver.Close();
        }

        [TestCase]
        public void clickButton2()
        {
            webDriver.Url = "https://www.youtube.com/";
            var wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, 15));
            var elem = wait.Until(condition =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(By.XPath("/html/body/ytd-app/div[1]/div/ytd-masthead/div[4]/div[1]/ytd-topbar-logo-renderer/a/div/ytd-logo/yt-icon/yt-icon-shape/icon-shape/div"));
                    return element.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
            IWebElement button = webDriver.FindElement(By.XPath("/html/body/ytd-app/div[1]/div/ytd-masthead/div[4]/div[1]/ytd-topbar-logo-renderer/a/div/ytd-logo/yt-icon/yt-icon-shape/icon-shape/div"));
            button.Click();
            webDriver.Close();
        }

        [TestCase]
        public void url2()
        {
            webDriver.Url = "https://www.youtube.com/";
            var wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, 15));
            var elem = wait.Until(condition =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(By.XPath("/html/body/ytd-app/div[1]/ytd-mini-guide-renderer/div/ytd-mini-guide-entry-renderer[2]/a"));
                    return element.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
            IWebElement button = webDriver.FindElement(By.XPath("/html/body/ytd-app/div[1]/ytd-mini-guide-renderer/div/ytd-mini-guide-entry-renderer[2]/a"));
            button.Click();
            webDriver.Navigate().Back();
            webDriver.Close();
        }

        [TestCase]
        public void input2()
        {
            webDriver.Url = "https://www.youtube.com/";

            var options = new ChromeOptions();
            options.AddArgument("no-sandbox");
            ChromeDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));

            var wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, 20));
            var elem = wait.Until(condition =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(By.XPath("/html/body/ytd-app/div[1]/div/ytd-masthead/div[4]/div[2]/ytd-searchbox/form/div[1]/div[1]/div/div[2]/input"));
                    return element.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
            IWebElement input = webDriver.FindElement(By.XPath("/html/body/ytd-app/div[1]/div/ytd-masthead/div[4]/div[2]/ytd-searchbox/form/div[1]/div[1]/div/div[2]/input"));
            input.SendKeys("тестирование сайта");
            webDriver.Close();
        }

        [TestCase]
        public void mainTitle3()
        {
            webDriver.Url = "https://assets.clip-studio.com/en-us";
            Assert.AreEqual("CLIP STUDIO ASSETS", webDriver.Title);
            webDriver.Close();
        }

        [TestCase]
        public void isDisplayed3()
        {
            webDriver.Url = "https://assets.clip-studio.com/en-us";
            var wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, 15));
            var elem = wait.Until(condition =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(By.XPath("/html/body/article/div[1]/section[1]/div[1]/div/div"));
                    return element.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
            webDriver.Close();
        }

        [TestCase]
        public void clickButton3()
        {
            webDriver.Url = "https://assets.clip-studio.com/en-us";
            var wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, 15));
            var elem = wait.Until(condition =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(By.XPath("/html/body/article/div[1]/section[1]/div[1]/div/span/button[2]"));
                    return element.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
            IWebElement button = webDriver.FindElement(By.XPath("/html/body/article/div[1]/section[1]/div[1]/div/span/button[2]"));
            button.Click();
            webDriver.Close();
        }

        [TestCase]
        public void url3()
        {
            webDriver.Url = "https://assets.clip-studio.com/en-us";
            var wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, 15));
            var elem = wait.Until(condition =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(By.XPath("/html/body/article/div[1]/section[4]/div/div[2]/h4/small/a"));
                    return element.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
            IWebElement button = webDriver.FindElement(By.XPath("/html/body/article/div[1]/section[4]/div/div[2]/h4/small/a"));
            button.Click();
            webDriver.Navigate().Back();
            webDriver.Close();
        }

        [TestCase]
        public void input3()
        {
            webDriver.Url = "https://assets.clip-studio.com/en-us";

            var options = new ChromeOptions();
            options.AddArgument("no-sandbox");
            ChromeDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));

            var wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, 20));
            var elem = wait.Until(condition =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(By.XPath("/html/body/article/div[1]/section[1]/div[1]/div/div/input"));
                    return element.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
            IWebElement input = webDriver.FindElement(By.XPath("/html/body/article/div[1]/section[1]/div[1]/div/div/input"));
            input.SendKeys("pencil");
            webDriver.Close();
        }


        [TestCase]
        public void mainTitle4()
        {
            webDriver.Url = "https://eda.ru/recepty";
            Assert.AreEqual("50073 пошаговых рецепта с фото на сайте «Еда»", webDriver.Title);
            webDriver.Close();
        }

        [TestCase]
        public void isDisplayed4()
        {
            webDriver.Url = "https://eda.ru/recepty";
            var wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, 15));
            var elem = wait.Until(condition =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(By.XPath("/html/body/div/main/div/div/div/div[1]/div[1]/div/div/div[1]/div/nav/ul/li/a/span"));
                    return element.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
            webDriver.Close();
        }

        [TestCase]
        public void clickButton4()
        {
            webDriver.Url = "https://eda.ru/recepty";
            var wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, 15));
            var elem = wait.Until(condition =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(By.XPath("/html/body/div/div[2]/div[3]/div/div/div[1]/div/div[2]/div/button[2]"));
                    return element.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
            IWebElement button = webDriver.FindElement(By.XPath("/html/body/div/div[2]/div[3]/div/div/div[1]/div/div[2]/div/button[2]"));
            button.Click();
            webDriver.Close();
        }

        [TestCase]
        public void url4()
        {
            webDriver.Url = "https://eda.ru/recepty";
            var wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, 15));
            var elem = wait.Until(condition =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(By.XPath("/html/body/div/div[2]/header/div/div/div[1]/ul/div/div/li[2]/a"));
                    return element.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
            IWebElement button = webDriver.FindElement(By.XPath("/html/body/div/div[2]/header/div/div/div[1]/ul/div/div/li[2]/a"));
            button.Click();
            webDriver.Navigate().Back();
            webDriver.Close();
        }

        [TestCase]
        public void input4()
        {
            webDriver.Url = "https://eda.ru/recepty";

            var options = new ChromeOptions();
            options.AddArgument("no-sandbox");
            ChromeDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));

            var wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, 20));
            var elem = wait.Until(condition =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(By.XPath("/html/body/div/div[2]/header/div/div/div[2]/div/button[1]"));
                    return element.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
            IWebElement input = webDriver.FindElement(By.XPath("/html/body/div/div[2]/header/div/div/div[2]/div/button[1]"));
            input.Click();
            input = webDriver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[2]/div/div[2]/div/input"));
            input.SendKeys("пельмени");
            webDriver.Close();
        }

        [TestCase]
        public void mainTitle5()
        {
            webDriver.Url = "https://www.mvideo.ru/";
            Assert.AreEqual("М.Видео - интернет-магазин цифровой и бытовой техники и электроники, низкие цены, большой каталог, отзывы.", webDriver.Title);
            webDriver.Close();
        }

        [TestCase]
        public void isDisplayed5()
        {
            webDriver.Url = "https://www.mvideo.ru/";
            var wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, 15));
            var elem = wait.Until(condition =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(By.XPath("/html/body/mvid-root/div/mvid-primary-layout/mvid-layout/div/div[1]/mvid-header-container/mvid-header/header/div[1]/div/a[1]"));
                    return element.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
            webDriver.Close();
        }

        [TestCase]
        public void clickButton5()
        {
            webDriver.Url = "https://www.mvideo.ru/";
            var wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, 15));
            var elem = wait.Until(condition =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(By.XPath("/html/body/mvid-root/div/mvid-primary-layout/mvid-layout/div/div[1]/mvid-header-container/mvid-header/header/div[2]/div/mvid-button/button"));
                    return element.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
            IWebElement button = webDriver.FindElement(By.XPath("/html/body/mvid-root/div/mvid-primary-layout/mvid-layout/div/div[1]/mvid-header-container/mvid-header/header/div[2]/div/mvid-button/button"));
            button.Click();
            webDriver.Close();
        }

        [TestCase]
        public void url5()
        {
            webDriver.Url = "https://www.mvideo.ru/";
            var wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, 15));
            var elem = wait.Until(condition =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(By.XPath("/html/body/mvid-root/div/mvid-primary-layout/mvid-layout/div/div[1]/mvid-header-container/mvid-header/header/div[3]/div/mvid-slide-panel/div/div[1]/mvid-floating-controls/div/div/div/div[3]/a"));
                    return element.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
            IWebElement button = webDriver.FindElement(By.XPath("/html/body/mvid-root/div/mvid-primary-layout/mvid-layout/div/div[1]/mvid-header-container/mvid-header/header/div[3]/div/mvid-slide-panel/div/div[1]/mvid-floating-controls/div/div/div/div[3]/a"));
            button.Click();
            webDriver.Navigate().Back();
            webDriver.Close();
        }

        [TestCase]
        public void input5()
        {
            webDriver.Url = "https://www.mvideo.ru/";

            var options = new ChromeOptions();
            options.AddArgument("no-sandbox");
            ChromeDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));

            var wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, 20));
            var elem = wait.Until(condition =>
            {
                try
                {
                    IWebElement element = webDriver.FindElement(By.XPath("/html/body/mvid-root/div/mvid-primary-layout/mvid-layout/div/div[1]/mvid-header-container/mvid-header/header/div[2]/div/div[2]/form/mvid-input/div/div/input"));
                    return element.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
            IWebElement input = webDriver.FindElement(By.XPath("/html/body/mvid-root/div/mvid-primary-layout/mvid-layout/div/div[1]/mvid-header-container/mvid-header/header/div[2]/div/div[2]/form/mvid-input/div/div/input"));
            input.SendKeys("ноутбук");
            webDriver.Close();
        }


        [TearDown]
        public void testEnd()
        {
            webDriver.Quit();
        }
    }
}
