using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexDemo;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckFirstNameValidation()
        {
            //Arrange
            UserRegi name = new UserRegi();
            string firstName = "Vidhya";
            Assert.IsTrue(name.IsValidName(firstName));
            
        }
        [TestMethod]
        public void CheckLastNameValidation()
        {
            //Arrange
            UserRegi name = new UserRegi();
            string lastName = "Darade";
            Assert.IsTrue(name.IsValidName(lastName));

        }
        [TestMethod]
        public void Emailvalidation()
        {
            UserRegi name = new UserRegi();
            string email = "abc@1.com";
            Assert.IsTrue(name.Email(email));
        }
        [TestMethod]
        public void Passwordvalidation()
        {
            UserRegi name = new UserRegi();
            string pwd = "abcDsf1#";
            Assert.IsTrue(name.Password(pwd));
        }
    }
}