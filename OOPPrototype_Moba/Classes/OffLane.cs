using OOPPrototype_Moba.Interfaces;

namespace OOPPrototype_Moba.Classes
{
    public class OffLane : Character, IFarmer
    {
        public string Farm()
        {
            return Name + " Farming....";
        }
    }
}
