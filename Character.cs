using System;

namespace CSharpDiscovery.Examen
{
    public abstract class Character
    {
        public string Name { get; set; }
        public float Health { get; set; }
        public float MaxHealth { get; set; }
        public DateTime CreationDate { get; set; }

        public Character()
        {
            Name = "NPC";
            Health = 100;
            MaxHealth = 100;
            CreationDate = DateTime.Now;
        }

        public Character(string name, float maxHealth)
        {
            Name = name;
            Health = maxHealth;
            MaxHealth = maxHealth;
            CreationDate = DateTime.Now;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0)
            {
                Health = 0;
            }
        }

        public string GetCreationDate()
        {
            return CreationDate.ToString("dd/MM HH:mm");
        }

        public override string ToString()
        {
            return Name + " : " + Health + "/" + MaxHealth;
        }

        public abstract void Special();
        public abstract void CibledSpecial(Character target);
    }
}
