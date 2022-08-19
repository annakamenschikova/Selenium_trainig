using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium___Task20
{
    public class HomePage
    {
        IWebDriver _driver;
        public List<IWebElement> LiTags;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }
        public IWebElement MailLink => _driver.FindElement(By.ClassName("desk-notif-card__login-new-item"));

       
        public void EnterMailLoginPage()
        {

            MailLink.Click();
        }
    }
}
