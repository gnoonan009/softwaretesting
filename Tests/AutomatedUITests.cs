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
        public void FirstNameNonNumber()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var FirstName = _driver.FindElement(By.XPath("/html/body/div/main/div/form/div[1]/input"));
            FirstName.SendKeys("545");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[1]/span"));

            Assert.Equal("First Name can only contain characters.", Error.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void FirstNameLength()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var FirstName = _driver.FindElement(By.XPath("/html/body/div/main/div/form/div[1]/input"));
            FirstName.SendKeys("Georgehasareallylongnameindeedthisiswaytoolongforanormalname");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[1]/span"));

            Assert.Equal("First Name cannot be empty or more than 15 characters.", Error.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void FirstNameRequired()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var FirstName = _driver.FindElement(By.XPath("/html/body/div/main/div/form/div[1]/input"));

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[1]/span"));

            Assert.Equal("The First Name field is required.", Error.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void LastNameNonNumber()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var LastName = _driver.FindElement(By.XPath("/html/body/div/main/div/form/div[2]/input"));
            LastName.SendKeys("545");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[2]/span"));

            Assert.Equal("Last Name can only contain characters.", Error.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void LastNameLength()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var LastName = _driver.FindElement(By.XPath("/html/body/div/main/div/form/div[2]/input"));
            LastName.SendKeys("Georgehasareallylongnameindeedthisiswaytoolongforanormalname");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[2]/span"));

            Assert.Equal("Last Name cannot be empty or more than 15 characters.", Error.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void LastNameRequired()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var LastName = _driver.FindElement(By.XPath("/html/body/div/main/div/form/div[2]/input"));

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[2]/span"));

            Assert.Equal("The Last Name field is required.", Error.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void PhoneNoDigits()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var Phone = _driver.FindElement(By.XPath("/html/body/div/main/div/form/div[3]/input"));
            Phone.SendKeys("George");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[3]/span"));

            Assert.Equal("The Phone field is not a valid phone number.", Error.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void PhoneLength()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var Phone = _driver.FindElement(By.XPath("/html/body/div/main/div/form/div[3]/input"));
            Phone.SendKeys("310310310310310");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[3]/span"));

            Assert.Equal("Phone number must be 10 digits.", Error.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void PhoneRequired()
        {
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var Email = _driver.FindElement(By.XPath("/html/body/div/main/div/form/div[3]/input"));

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[3]/span"));

            Assert.Equal("The Phone field is required.", Error.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void EmailFormat()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var Email = _driver.FindElement(By.XPath("/html/body/div/main/div/form/div[4]/input"));
            Email.SendKeys("george2313@df");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[4]/span"));

            Assert.Equal("Email is in invalid format.", Error.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void EmailLength()
        {

            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var Email = _driver.FindElement(By.XPath("/html/body/div/main/div/form/div[4]/input"));
            Email.SendKeys("Georgehasareallylongnameindeedthisiswaytoolongforanormalname@somelongemaildomain.com");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[4]/span"));

            Assert.Equal("Email cannot be empty or more than 30 characters.", Error.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void EmailRequired()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var Email = _driver.FindElement(By.XPath("/html/body/div/main/div/form/div[4]/input"));

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[4]/span"));

            Assert.Equal("The Email field is required.", Error.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void PasswordFormat()
        {

            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");


            var Password = _driver.FindElement(By.XPath("/html/body/div/main/div/form/div[5]/input"));
            Password.SendKeys("george2313@df");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[5]/span"));

            Assert.Equal("Password and confirmed password do not match.", Error.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void PasswordLength()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var Password = _driver.FindElement(By.XPath("/html/body/div/main/div/form/div[5]/input"));
            Password.SendKeys("someincrediblyl0ngpasswordthatislongerthan30character");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[5]/span"));

            Assert.Equal("Password cannot be empty or more than 30 characters.", Error.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void PasswordRequired()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var Password = _driver.FindElement(By.XPath("/html/body/div/main/div/form/div[5]/input"));

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[5]/span"));

            Assert.Equal("The Password field is required.", Error.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void PasswordNotAllLetters()
        {
            
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var Password = _driver.FindElement(By.XPath("/html/body/div/main/div/form/div[5]/input"));
            Password.SendKeys("Password");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[5]/span"));

            Assert.Equal("Password must contain at least 1 digit and 1 character.", Error.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void PasswordNotAllNumbers()
        {
            
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var Password = _driver.FindElement(By.XPath("/html/body/div/main/div/form/div[5]/input"));
            Password.SendKeys("0349823084209890");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[5]/span"));

            Assert.Equal("Password must contain at least 1 digit and 1 character.", Error.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void ConfirmPasswordRequired()
        {
   
            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var Password = _driver.FindElement(By.XPath("/html/body/div/main/div/form/div[5]/input"));

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[6]/span"));

            Assert.Equal("The Confirm Password field is required.", Error.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void PasswordMatchesConfirmPassword()
        {


            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");


            var Password = _driver.FindElement(By.XPath("/html/body/div/main/div/form/div[5]/input"));

            Password.SendKeys("SomePassword3#");

            var PasswordConfirmed = _driver.FindElement(By.XPath("/html/body/div/main/div/form/div[6]/input"));
            PasswordConfirmed.SendKeys("SomePassword4#");
            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var ErrorPassword = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[5]/span"));
            var ErrorPasswordConfirmed = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[6]/span"));

            Assert.Equal("Password and confirmed password do not match.", ErrorPassword.Text);
            Assert.Equal("Password and confirmed password do not match.", ErrorPasswordConfirmed.Text);
        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void ConfirmPasswordNotAllLetters()
        {

            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var Password = _driver.FindElement(By.XPath("/html/body/div/main/div/form/div[5]/input"));
            var PasswordC = _driver.FindElement(By.XPath("/html/body/div/main/div/form/div[6]/input"));
            Password.SendKeys("Password");
            PasswordC.SendKeys("Password");

            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[6]/span"));

            Assert.Equal("Password Confirm must contain at least 1 digit and 1 character.", Error.Text);

        }

        /*
         * Author: George Noonan (gn8fe)
         */
        [Fact]
        public void ConfirmPasswordNotAllNumbers()
        {

            _driver.Navigate()
                .GoToUrl("https://softwaretestinggn8fe.herokuapp.com/");

            var Password = _driver.FindElement(By.XPath("/html/body/div/main/div/form/div[5]/input"));
            var PasswordC = _driver.FindElement(By.XPath("/html/body/div/main/div/form/div[6]/input"));
            Password.SendKeys("0349823084209890");
            PasswordC.SendKeys("0349823084209890");
            _driver.FindElement(By.XPath("/html/body/div/main/div/form/button")).Click();

            var Error = _driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[6]/span"));

            Assert.Equal("Password Confirm must contain at least 1 digit and 1 character.", Error.Text);

        }

    }
}
