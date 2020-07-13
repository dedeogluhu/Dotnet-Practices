using OOPPrototype_Moba.Interfaces;

namespace OOPPrototype_Moba.Classes
{
    public class SafeCarry : Character, IFarmer
    {
        public string Farm()
        {
            return Name + " Farming...";
        }
    }
}
