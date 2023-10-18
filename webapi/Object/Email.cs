namespace webapi.Object
{
    public class Email
    {
        private string _prefix;
        private string _domain;

        public Email(string prefix, string domain)
        {
            _prefix = prefix;
            _domain = domain;
        }

        public Email(string mail)
        {
            this.Value = mail;
        }

        public string Value
        {
            get => $"{_prefix}@{_domain}";
            set
            {
                var split = value.Split('@');
                _prefix = split[0];
                _domain = split[1];
            }
        }
    }
}