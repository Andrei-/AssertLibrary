namespace AssertLibrary.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Assert = AssertLibrary.Assert;

    [TestClass]
    public class IsValidEmail
    {
        [TestMethod]
        public void IsValidEmail_With_Valid_Strings()
        {
            Assert.IsValidEmail("test@email.com");
        }

        [TestMethod, ExpectedException(typeof(AssertException))]
        public void IsValidEmail_With_Null()
        {
            Assert.IsValidEmail(null);
        }

        [TestMethod, ExpectedException(typeof(AssertException))]
        public void IsValidEmail_With_EmptyString()
        {
            Assert.IsValidEmail(string.Empty);
        }

        [TestMethod, ExpectedException(typeof(AssertException))]
        public void IsValidEmail_With_WrongEmailStrings()
        {
            Assert.IsValidEmail("blabla");
        }
    }
}
