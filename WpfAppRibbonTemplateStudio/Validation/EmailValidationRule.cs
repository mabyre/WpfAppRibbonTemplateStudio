using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace WpfAppRibbonTemplateStudio.Validation
{
    public class EmailValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            // Is a valid email address?
            var pattern =
                @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*([,;]\s*\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)*";
            if (!Regex.IsMatch((string)value, pattern))
            {
                var msg = $"{value} is not a valid email address.";
                return new ValidationResult(false, msg);
            }

            // Email address is valid
            return new ValidationResult(true, null);
        }
    }
}
