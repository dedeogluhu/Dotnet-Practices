using System.Collections.Generic;

namespace OOPPrototype_Restaurant.Classes
{
    public class Order
    {
        public List<Food> Foods { get; set; }
        public Table Table { get; set; }
        public int TotalPrice { get; set; }
        public override string ToString()
        {
            string a = "";

            foreach (Food item in Foods)
            {
                a += item;
                a += " ";
            }

            return $"{Table.TableNo} - {a}";
        }
    }
}
