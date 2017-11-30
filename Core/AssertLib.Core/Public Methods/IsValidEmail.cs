namespace AssertLibrary
{
    using System.Diagnostics;
    using System.Globalization;
    using System.Text.RegularExpressions;

    public static partial class Assert
    {
        /// <summary>
        /// Asserts that the given string is valid email address.
        /// </summary>
        /// <param name="value">String to check</param>
        /// <param name="variableName">Variable name to include in the error message (optional)</param>
        public static void IsValidEmail(string value, string variableName = null)
        {
            Check(IsEmailValid(value), IsValidEmailMessage(variableName));
        }

        private static string IsValidEmailMessage(string variableName)
        {
            return variableName == null ?
                    "Should be a valid email address." :
                    string.Format(CultureInfo.CurrentCulture, "\"{0}\" should be a valid email address.", variableName);
        }

        // 
        const string EMAIL_STRING_PATTERN = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

        /// <summary>
        /// Validates an email address using the regex provided by W3C <see href="https://www.w3.org/TR/2012/WD-html-markup-20120320/input.email.html#input.email.attrs.value.single">HERE</see>
        /// </summary>
        /// <param name="email">Email string to validate</param>
        private static bool IsEmailValid(string email)
        {
            return !string.IsNullOrWhiteSpace(email) && Regex.IsMatch(email, EMAIL_STRING_PATTERN, RegexOptions.IgnoreCase | RegexOptions.Compiled);
        }
    }
}
