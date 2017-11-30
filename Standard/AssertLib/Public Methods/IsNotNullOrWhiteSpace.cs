namespace AssertLibrary
{
    using System.Globalization;

    public static partial class Assert
    {
        /// <summary>
        /// Asserts that the given string is null or empty.
        /// </summary>
        /// <param name="value">String to check</param>
        /// <param name="variableName">Variable name to include in the error message (optional)</param>
        public static void IsNotNullOrWhiteSpace(string value, string variableName = null)
        {
            Check(!string.IsNullOrWhiteSpace(value), IsNotNullOrWhiteSpaceMessage(variableName));
        }

        private static string IsNotNullOrWhiteSpaceMessage(string variableName)
        {
            return variableName == null ?
                "Should have a value other then null or white space at this point." :
                string.Format(CultureInfo.CurrentCulture, "\"{0}\" should have a value other then null or white space at this point.", variableName);
        }
    }
}
