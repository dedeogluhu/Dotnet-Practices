using OOPPrototype_Moba.Interfaces;

namespace OOPPrototype_Moba.Classes
{
    public class Support : Character, ISupport
    {
        public string BuyWards()
        {
            return Name + " Buying Wards...";
        }

        public string Heal()
        {
            return Name + " Healing Our Carries...";
        }
    }
}
