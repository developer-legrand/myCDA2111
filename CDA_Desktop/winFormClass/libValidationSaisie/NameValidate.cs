using System.Text.RegularExpressions;

namespace libValidationSaisie
{
    public class NameValidate
    {
        private Regex regexName;
        private string name;

        public NameValidate()
        {
            regexName = new Regex(@"^([a-zA-Z]+[-]?[a-zA-Z]+){2,30}$");
            name = String.Empty;
        }

        public bool IsValid(string _name)
        {
            name = _name;
            return regexName.IsMatch(name);
        }
    }
}