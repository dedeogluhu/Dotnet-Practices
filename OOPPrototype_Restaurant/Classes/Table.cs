namespace OOPPrototype_Restaurant.Classes
{
    public class Table
    {
        public int TableNo { get; set; }
        public int Fee { get; set; }

        public void Payment()
        {
            Fee = 0;
        }
    }
}
