using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Xunit;

namespace Tests
{
    public class AutomatedUITests : IDisposable
    {
        private readonly IWebDriver _driver;
        public AutomatedUITests()
        {
            _driver = new ChromeDriver();

        }

        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void TestCase1()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var type = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[1]/input"));
            var price = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[4]/input"));
            var location = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[3]/input"));
            var brand = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[2]/input"));

            type.SendKeys("Gas");
            price.SendKeys("15000");
            location.SendKeys("China");
            brand.SendKeys("Mercedes");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/div/ul/li"));

            Assert.Equal("No Mercedes found in China at this price range.", Error.Text);
        }

        /*
        * Author: George Noonan (gn8fe)
        */
        [Fact]
        public void TestCase2()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var type = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[1]/input"));
            var price = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[4]/input"));
            var location = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[3]/input"));
            var brand = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[2]/input"));

            type.SendKeys("Gas");
            price.SendKeys("15000");
            location.SendKeys("China");
            brand.SendKeys("BMW");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/div/ul/li"));

            Assert.Equal("No BMW found in China at this price range.", Error.Text);

        }

        /*
        * Author: George Noonan (gn8fe)
        */
        [Fact]
        public void TestCase3()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var type = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[1]/input"));
            var price = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[4]/input"));
            var location = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[3]/input"));
            var brand = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[2]/input"));

            type.SendKeys("Gas");
            price.SendKeys("15000");
            location.SendKeys("China");
            brand.SendKeys("Audi");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var SuccessMessage = _driver.FindElement(By.XPath("/html/body/div/main/div[1]/strong"));

            Assert.Equal("Success!", SuccessMessage.Text);

        }

        /*
        * Author: George Noonan (gn8fe)
        */
        [Fact]
        public void TestCase4()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var type = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[1]/input"));
            var price = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[4]/input"));
            var location = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[3]/input"));
            var brand = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[2]/input"));

            type.SendKeys("Gas");
            price.SendKeys("15000");
            location.SendKeys("China");
            brand.SendKeys("Tesla");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/div/ul/li"));

            Assert.Equal("Tesla only produces electric vehicles.", Error.Text);

        }

        /*
        * Author: George Noonan (gn8fe)
        */
        [Fact]
        public void TestCase5()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var type = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[1]/input"));
            var price = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[4]/input"));
            var location = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[3]/input"));
            var brand = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[2]/input"));

            type.SendKeys("Gas");
            price.SendKeys("15000");
            location.SendKeys("LA");
            brand.SendKeys("Mercedes");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/div/ul/li"));

            Assert.Equal("No Mercedes found in LA at this price range.", Error.Text);

        }

        /*
        * Author: George Noonan (gn8fe)
        */
        [Fact]
        public void TestCase6()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var type = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[1]/input"));
            var price = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[4]/input"));
            var location = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[3]/input"));
            var brand = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[2]/input"));

            type.SendKeys("Gas");
            price.SendKeys("15000");
            location.SendKeys("Miami");
            brand.SendKeys("Mercedes");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/div/ul/li"));

            Assert.Equal("No Mercedes found in Miami at this price range.", Error.Text);

        }

        /*
        * Author: George Noonan (gn8fe)
        */
        [Fact]
        public void TestCase7()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var type = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[1]/input"));
            var price = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[4]/input"));
            var location = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[3]/input"));
            var brand = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[2]/input"));

            type.SendKeys("Gas");
            price.SendKeys("15000");
            location.SendKeys("London");
            brand.SendKeys("Mercedes");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var SuccessMessage = _driver.FindElement(By.XPath("/html/body/div/main/div[1]/strong"));

            Assert.Equal("Success!", SuccessMessage.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void TestCase8()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var type = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[1]/input"));
            var price = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[4]/input"));
            var location = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[3]/input"));
            var brand = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[2]/input"));

            type.SendKeys("Gas");
            price.SendKeys("35000");
            location.SendKeys("China");
            brand.SendKeys("Mercedes");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var SuccessMessage = _driver.FindElement(By.XPath("/html/body/div/main/div[1]/strong"));

            Assert.Equal("Success!", SuccessMessage.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void TestCase9()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var type = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[1]/input"));
            var price = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[4]/input"));
            var location = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[3]/input"));
            var brand = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[2]/input"));

            type.SendKeys("Gas");
            price.SendKeys("50000");
            location.SendKeys("China");
            brand.SendKeys("Mercedes");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var SuccessMessage = _driver.FindElement(By.XPath("/html/body/div/main/div[1]/strong"));

            Assert.Equal("Success!", SuccessMessage.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void TestCase10()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var type = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[1]/input"));
            var price = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[4]/input"));
            var location = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[3]/input"));
            var brand = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[2]/input"));

            type.SendKeys("Gas");
            price.SendKeys("100000");
            location.SendKeys("China");
            brand.SendKeys("Mercedes");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var SuccessMessage = _driver.FindElement(By.XPath("/html/body/div/main/div[1]/strong"));

            Assert.Equal("Success!", SuccessMessage.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void TestCase11()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var type = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[1]/input"));
            var price = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[4]/input"));
            var location = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[3]/input"));
            var brand = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[2]/input"));

            type.SendKeys("Electric");
            price.SendKeys("15000");
            location.SendKeys("China");
            brand.SendKeys("Mercedes");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/div/ul/li"));

            Assert.Equal("Mercedes does not offer electric powered vehicles in China.", Error.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void TestCase12()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var type = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[1]/input"));
            var price = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[4]/input"));
            var location = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[3]/input"));
            var brand = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[2]/input"));

            type.SendKeys("Hybrid");
            price.SendKeys("15000");
            location.SendKeys("China");
            brand.SendKeys("Mercedes");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var SuccessMessage = _driver.FindElement(By.XPath("/html/body/div/main/div[1]/strong"));

            Assert.Equal("Success!", SuccessMessage.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void TestCase13()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var type = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[1]/input"));
            var price = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[4]/input"));
            var location = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[3]/input"));
            var brand = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[2]/input"));

            type.SendKeys("Diesel");
            price.SendKeys("15000");
            location.SendKeys("China");
            brand.SendKeys("Mercedes");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/div/ul/li"));

            Assert.Equal("Mercedes does not offer diesel powered vehicles in China.", Error.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void TestCase15()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var type = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[1]/input"));
            var price = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[4]/input"));
            var location = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[3]/input"));
            var brand = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[2]/input"));

            type.SendKeys("Electric");
            price.SendKeys("15000");
            location.SendKeys("China");
            brand.SendKeys("BMW");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/div/ul/li"));

            Assert.Equal("BMW does not offer electric powered cars in China.", Error.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void TestCase16()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var type = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[1]/input"));
            var price = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[4]/input"));
            var location = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[3]/input"));
            var brand = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[2]/input"));

            type.SendKeys("Electric");
            price.SendKeys("15000");
            location.SendKeys("China");
            brand.SendKeys("Audi");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/div/ul/li"));

            Assert.Equal("Audi does not offer electric powered cars in China.", Error.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void TestCase17()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var type = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[1]/input"));
            var price = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[4]/input"));
            var location = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[3]/input"));
            var brand = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[2]/input"));

            type.SendKeys("Electric");
            price.SendKeys("15000");
            location.SendKeys("China");
            brand.SendKeys("Tesla");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var SuccessMessage = _driver.FindElement(By.XPath("/html/body/div/main/div[1]/strong"));

            Assert.Equal("Success!", SuccessMessage.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void TestCase18()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var type = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[1]/input"));
            var price = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[4]/input"));
            var location = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[3]/input"));
            var brand = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[2]/input"));

            type.SendKeys("Electric");
            price.SendKeys("15000");
            location.SendKeys("LA");
            brand.SendKeys("Mercedes");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/div/ul/li"));

            Assert.Equal("No electric Mercedes found in LA at this price range.", Error.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void TestCase19()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var type = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[1]/input"));
            var price = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[4]/input"));
            var location = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[3]/input"));
            var brand = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[2]/input"));

            type.SendKeys("Electric");
            price.SendKeys("15000");
            location.SendKeys("Miami");
            brand.SendKeys("BMW");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/div/ul/li"));

            Assert.Equal("No electric BMW found in Miami at this price range.", Error.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void TestCase20()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var type = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[1]/input"));
            var price = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[4]/input"));
            var location = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[3]/input"));
            var brand = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[2]/input"));

            type.SendKeys("Electric");
            price.SendKeys("15000");
            location.SendKeys("London");
            brand.SendKeys("Audi");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/div/ul/li"));

            Assert.Equal("Audi does not offer electric vehicles in the U.K.", Error.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void TestCase21()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var type = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[1]/input"));
            var price = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[4]/input"));
            var location = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[3]/input"));
            var brand = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[2]/input"));

            type.SendKeys("Electric");
            price.SendKeys("35000");
            location.SendKeys("China");
            brand.SendKeys("Tesla");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var SuccessMessage = _driver.FindElement(By.XPath("/html/body/div/main/div[1]/strong"));

            Assert.Equal("Success!", SuccessMessage.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void TestCase22()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var type = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[1]/input"));
            var price = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[4]/input"));
            var location = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[3]/input"));
            var brand = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[2]/input"));

            type.SendKeys("Electric");
            price.SendKeys("50000");
            location.SendKeys("China");
            brand.SendKeys("Mercedes");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var SuccessMessage = _driver.FindElement(By.XPath("/html/body/div/main/div[1]/strong"));

            Assert.Equal("Success!", SuccessMessage.Text);

        }

        /*
        * Author: George Noonan (gn8fe)
        */
        [Fact]
        public void TestCase23()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var type = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[1]/input"));
            var price = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[4]/input"));
            var location = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[3]/input"));
            var brand = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[2]/input"));

            type.SendKeys("Electric");
            price.SendKeys("100000");
            location.SendKeys("China");
            brand.SendKeys("BMW");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var SuccessMessage = _driver.FindElement(By.XPath("/html/body/div/main/div[1]/strong"));

            Assert.Equal("Success!", SuccessMessage.Text);

        }
    }
}
