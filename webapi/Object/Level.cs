namespace webapi.Object
{
    public class Level
    {
        public string Name { get; private set; }
        public int Number { get; private set; }

        public Level(int number)
        {
            this.Set(number);
        }

        public Level Set(int number)
        {
            this.Name = number == 1 ? $"{number} er" : $"{number} ème";
            this.Number = number;
            return this;
        }
    }
}