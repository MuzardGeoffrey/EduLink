namespace webapi.Object
{
    public class Pseudo
    {
        private string _value;
        public string Shortened { get; private set; }

        public Pseudo(string value)
        {
            Value = value;
        }

        public string Value
        {
            get => _value;
            set
            {
                _value = value;
                Shortened = value[..3];
            }
        }
    }
}