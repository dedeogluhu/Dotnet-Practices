﻿namespace OOPPrototype_Restaurant.Classes
{
    public class Table
    {
        public string TableNo { get; set; }
        public int TotalFee { get; set; }
        public Worker Waiter { get; set; }

        public void Payment()
        {
            TotalFee = 0;
        }

        public override string ToString()
        {
            return $"Table {TableNo} - {TotalFee}$ - {Waiter?.Name}";
        }
    }
}
