using System.Reflection;
using UserRegistrationMstest;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expected = "Subodh";

            FirstName firstname = new FirstName("Subodh");
            string actual = firstname.ValidateFirstName();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]
        public void TestLastName()
        {
            string expected = "Nagalwade";

            LastName lastName = new LastName("Nagalwade");
            string actual = lastName.ValidateLastName();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]
        public void TestEmail()
        {
            string expected = "abc.xyz@bl.co.in";

            Email email = new Email("abc.xyz@bl.co.in");
            string actual = email.ValidateEmail();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]
         public void TestMobileNumber()
        {
            string expected = "+91 7123456789";

            Mobile mobile = new Mobile("+91 7123456789");
            string actual = mobile.ValideMobileNumber();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
         }
        [TestMethod]
        public void TestPasswordRuleOne()
        {
            string expected = "subodhnagl";

            Rule1 rule1 = new Rule1("subodhnagl");
            string actual = rule1.ValidatePassword();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]

        public void TestPasswordRuleTwo()
        {
            string expected = "SubodhNagal";

            Rule2 rule2 = new Rule2("SubodhNagal");
            string actual = rule2.ValidatePassword();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]
        public void TestPasswordRuleThree()
        {
            string expected = "SubodhNagal123";

            Rule3 rule3 = new Rule3("SubodhNagal123");
            string actual = rule3.ValidatePassword();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]
        public void TestPasswordRuleFour()
        {
            string expected = "Subodh@123";

            Rule4 rule4 = new Rule4("Subodh@123");
            string actual = rule4.ValidatePassword();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]
        public void TestEmailSamples()
        {
            string expected1 = "abc.400@abc.com.au";
            string expected2 = "abc@.com.mn";

            EmailSample emailSample = new EmailSample("abc.400@abc.com.au");
            string actual1 = emailSample.ValidateEmail();

            EmailSample emailSample1 = new EmailSample("abc@.com.mn");
            string actual2 = emailSample1.ValidateEmail();

            Assert.AreEqual(expected1, actual1);
            Assert.AreNotEqual(expected2, actual2);
            Console.WriteLine(actual1);
            Console.WriteLine(actual2);
        }
    }
}