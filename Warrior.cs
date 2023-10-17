using System;

namespace CSharpDiscovery.Examen
{
    public class Warrior : Character
    {
        public bool Bravery { get; set; }

        public Warrior() : base()
        {
            Bravery = false;
        }

        public Warrior(string name, float maxHealth) : base(name, maxHealth)
        {
            Bravery = false;
        }

        public override void Special()
        {
            if (Health < 30)
                Bravery = true;
            else
                Bravery = false;
        }

        public override void CibledSpecial(Character target)
        {
            if (Bravery = true)
                target.TakeDamage(40);
            else
                target.TakeDamage(25);

            if (target.Health < 0)
                target.Health = 0;
        }

        public override string ToString()
        {
            return Name + " : " + Health + "/" + MaxHealth + " | Classe : Guerrier | Bravoure :" + Bravery;
        }
    }
}
