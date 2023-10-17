using System;

namespace CSharpDiscovery.Examen
{
    public class Cleric : Character
    {
        public float Mana { get; set; }

        public Cleric() : base()
        {
            Mana = 100;
        }

        public Cleric(string name, float maxHealth) : base(name, maxHealth)
        {
            Mana = 100;
        }

        public override void Special()
        {
            Mana += 10;

            if (Mana >= 100)
                Mana = 100;
        }

        public override void CibledSpecial(Character target)
        {
            target.Health += 15;

            if (target.Health >= target.MaxHealth)
                target.Health = target.MaxHealth;
        }

        public override string ToString()
        {
            return Name + " : " + Health + "/" + MaxHealth + " | Classe : Clerc | Mana :" + Mana;
        }
    }
}
