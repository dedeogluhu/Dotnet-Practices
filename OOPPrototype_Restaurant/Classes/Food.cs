namespace OOPPrototype_Restaurant.Classes
{
    public class Food
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Price}$";
        }
    }
}
