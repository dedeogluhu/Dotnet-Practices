namespace OOPPrototype_Restaurant.Classes
{
    public class Worker
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Wage { get; set; }

        public override string ToString()
        {
            return $"{Name} - Age: {Age} - Wage: {Wage}";
        }
    }
}
