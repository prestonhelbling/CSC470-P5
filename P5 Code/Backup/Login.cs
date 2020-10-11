using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using P5_Code;

namespace UnitTestFakeAppUserRepository
{
    [TestClass]
    public class Login
    {
        [TestMethod]
        public void LoginWithCorrectCredentialsSuccessful()
        {
            //Arrange
            const string userName = "BobTheBuilder";
            const string password = "YesWeCan";
            FakeAppUserRepository userDatabase;

            //Act
            userDatabase = new FakeAppUserRepository();

            //Assert
            Assert.IsTrue(userDatabase.Login(userName, password));
        }

        [TestMethod]
        public void LoginWithIncorrectCredentialsFail()
        {
            //Arrange
            const string userName = "BobTheBuilder";
            const string password = "NoWeCanNot";
            FakeAppUserRepository userDatabase;

            //Act
            userDatabase = new FakeAppUserRepository();

            //Assert
            Assert.IsFalse(userDatabase.Login(userName, password));
        }
    }
}
