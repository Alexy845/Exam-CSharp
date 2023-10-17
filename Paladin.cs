
public class Paladin : Character, IHealer, ITank
{
    public int Buff { get; set; }

    public int HealPower { get; set; }

    public int AttackPower { get; set; }

    public Paladin()
    {
        Buff = 0;
        HealPower = 15;
        AttackPower = 25;
    }

    public Paladin(string name, float maxHealth)
    {
        Buff = 0;
        HealPower = 15;
        AttackPower = 25;
    }

    public override void Special()
    {
        Health += HealPower + Buff;
    }

    public override void CibledSpecial(Character target)
    {
        int damage = AttackPower + Buff;
        target.TakeDamage(damage);
        Buff = Math.Min(Buff + 3);
        if (Buff >= 15)
        {
            Buff = 15
        }
    }

    public override string ToString()
    {
        return Name + ": " + Health + "/" + MaxHealth + " | Classe : Paladin | Buff : " + Buff;
    }
}
