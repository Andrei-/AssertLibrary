namespace AssertLibrary.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Assert = AssertLibrary.Assert;

    [TestClass]
    public class IsNotNullOrWhiteSpace
    {
        [TestMethod]
        public void IsNotNullOrEmpty_With_Valid_String()
        {
            Assert.IsNotNullOrWhiteSpace("test");
        }

        [TestMethod, ExpectedException(typeof(AssertException))]
        public void IsNotNullOrEmpty_With_Null()
        {
            Assert.IsNotNullOrWhiteSpace(null);
        }

        [TestMethod, ExpectedException(typeof(AssertException))]
        public void IsNotNullOrEmpty_With_EmptyString()
        {
            Assert.IsNotNullOrWhiteSpace(string.Empty);
        }
    }
}
