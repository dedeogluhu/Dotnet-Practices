using OOPPrototype_Moba.Interfaces;

namespace OOPPrototype_Moba.Classes
{
    public class MidLane : Character, IFarmer
    {
        public string Farm()
        {
            return Name + " Farming....";
        }
    }
}
