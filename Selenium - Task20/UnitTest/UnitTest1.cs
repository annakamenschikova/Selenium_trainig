using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;
using static Selenium___Task20.HomePage;
using static Selenium___Task20.UsernamePage;
using static Selenium___Task20.PasswordPage;
using static Selenium___Task20.MailPage;


namespace Selenium___Task20
{
    public class UnitTest
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--incognito");
            driver = new ChromeDriver(options);
        }

        [Test]
        public void SuccessfullLogin()
        {

            driver.Url = "https://yandex.com";
            HomePage homePage = new HomePage(driver);
            Thread.Sleep(2000);

            homePage.EnterMailLoginPage();
            Thread.Sleep(2000);

            UsernamePage usernamePage = new UsernamePage(driver);
            usernamePage.EnterUsername("zqweasdzxc12");
            Thread.Sleep(2000);

            PasswordPage passwordPage = new PasswordPage(driver);
            passwordPage.EnterPassword("qweasdzxcQWE12");

            Thread.Sleep(5000);

            MailPage mailPage = new MailPage(driver);

            Assert.IsTrue(mailPage.IsLoggedIn("zqweasdzxc12"));

            driver.Close();
        }
    }
}