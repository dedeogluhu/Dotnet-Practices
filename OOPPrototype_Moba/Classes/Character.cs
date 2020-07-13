namespace OOPPrototype_Moba.Classes
{
    public abstract class Character
    {
        public string Name { get; set; }
        public string PrimaryAttribute { get; set; }
        public int Level { get; set; }
        public string AttackType { get; set; }
        public string UltiName { get; set; }
        public string SkillName { get; set; }
        public string Attack()
        {
            if(AttackType == "Melee")
            {
                return "Melee Attack!";
            }
            else if(AttackType == "Ranged")
            {
                return "Ranged Attack!";
            }
            else
            {
                return "";
            }
        }

        public string UseSkill()
        {
            return SkillName + "!";
        }
        public string UseUlti()
        {
            return UltiName + "!";
        }

        public override string ToString()
        {
            return $"{Name} - {PrimaryAttribute} - {Level} - {AttackType} - {SkillName} - {UltiName} - {GetType().Name}";
        }
    }
}
