using EmailSolution; 

namespace EmailValidatorTest
{
    [TestClass]
    public class EmailValidatorUnitTest : EmailTestBase
    {
       
        [TestMethod]

        public void myEmailTest1()
        {
           TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("goodemail1", "edwincopeland@outlook.com");
            string result = EmailValidator.IsValidEmail(email);
            Assert.AreEqual(result, "email is valid");
        }
        

        [TestMethod]
        public void myEmailTest2()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("goodemail2", "edwincopeland@outlook.com");
            string result = EmailValidator.IsValidEmail(email);
            Assert.AreEqual(result, "email is valid");
        }

        [TestMethod]
        public void myEmailTest3()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("goodemail3", "edwincopeland@outlook.com");
            string result = EmailValidator.IsValidEmail(email);
            Assert.AreEqual(result, "email is valid");
        }

        [TestMethod]
        public void myEmailTest4()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("goodemail4", "edwincopeland@outlook.com");
            string result = EmailValidator.IsValidEmail(email);
            Assert.AreEqual(result, "email is valid");
        }

        [TestMethod]
        public void myEmailTest5()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("goodemail5", "edwincopeland@outlook.com");
            string result = EmailValidator.IsValidEmail(email);
            Assert.AreEqual(result, "email is valid");
        }

        [TestMethod]
        public void myEmailTest6()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("goodemail6", "edwincopeland@outlook.com");
            string result = EmailValidator.IsValidEmail(email);
            Assert.AreEqual(result, "email is valid");
        }

        [TestMethod]
        public void myEmailTest7()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("goodemail7", "edwincopeland@outlook.com");
            string result = EmailValidator.IsValidEmail(email);
            Assert.AreEqual(result, "email is valid");
        }

        [TestMethod]
        public void myEmailTest8()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("goodemail8", "edwincopeland@outlook.com");
            string result = EmailValidator.IsValidEmail(email);
            Assert.AreEqual(result, "email is valid");
        }

        [TestMethod]
        public void myEmailTest9()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("goodemail9", "edwincopeland@outlook.com");
            string result = EmailValidator.IsValidEmail(email);
            Assert.AreEqual(result, "email is valid");
        }

        [TestMethod]
        public void myEmailTest10()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("goodemail10", "edwincopeland@outlook.com");
            string result = EmailValidator.IsValidEmail(email);
            Assert.AreEqual(result, "email is valid");
        }


        [TestMethod]
        public void badEmailTest1()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("bademail1", "edwincopeland@outlook.com");
            string result = EmailValidator.IsValidEmail(email);
            Assert.AreEqual(result, "email is invalid");
        }

        [TestMethod]
        public void badEmailTest2()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("bademail2", "edwincopeland@outlook.com");
            string result = EmailValidator.IsValidEmail(email);
            Assert.AreEqual(result, "email is invalid");
        }

        [TestMethod]
        public void badEmailTest3()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("bademail3", "edwincopeland@outlook.com");
            string result = EmailValidator.IsValidEmail(email);
            Assert.AreEqual(result, "email is invalid");
        }

        [TestMethod]
        public void badEmailTest4()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("bademail4", "edwincopeland@outlook.com");
            string result = EmailValidator.IsValidEmail(email);
            Assert.AreEqual(result, "email is invalid");
        }

        [TestMethod]
        public void badEmailTest5()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("bademail5", "edwincopeland@outlook.com");
            string result = EmailValidator.IsValidEmail(email);
            Assert.AreEqual(result, "email is invalid");
        }

        [TestMethod]
        public void badEmailTest6()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("bademail6", "edwincopeland@outlook.com");
            string result = EmailValidator.IsValidEmail(email);
            Assert.AreEqual(result, "email is invalid");
        }

        [TestMethod]
        public void badEmailTest7()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("bademail7", "edwincopeland@outlook.com");
            string result = EmailValidator.IsValidEmail(email);
            Assert.AreEqual(result, "email is invalid");
        }

        [TestMethod]
        public void badEmailTest8()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("bademail8", "edwincopeland@outlook.com");
            string result = EmailValidator.IsValidEmail(email);
            Assert.AreEqual(result, "email is invalid");
        }

        [TestMethod]
        public void badEmailTest9()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("bademail9", "edwincopeland@outlook.com");
            string result = EmailValidator.IsValidEmail(email);
            Assert.AreEqual(result, "email is invalid");
        }

        [TestMethod]
        public void badEmailTest10()
        {
            TestContext.WriteLine(TestContext.TestName);
            string email = GetTestSetting<string>("bademail10", "edwincopeland@outlook.com");
            string result = EmailValidator.IsValidEmail(email);
            Assert.AreEqual(result, "email is invalid");
        }
    }
}