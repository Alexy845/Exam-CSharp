public interface IHealer
{
    int HealPower { get; set; }

    void DoubleHeal(Character target1, Character target2);

    int GetHeal();
}

public class Cleric : Character, IHealer
{
    public int HealPower { get; set; }

    public Cleric()
    {
        HealPower = 15;
    }

    public Cleric(string name, float maxHealth)
    {
        HealPower = 15;
    }

    public void DoubleHeal(Character target1, Character target2)
    {
        target1.Health += HealPower / 2;
        target2.Health += HealPower / 2;
        Health -= HealPower;
    }

    public int GetHeal()
    {
        return HealPower;
    }
}

public interface ITank
{
    int AttackPower { get; set; }

    void DoubleHit(Character target);

    int GetPower();
}

public class Warrior : Character, ITank
{
    public int AttackPower { get; set; }

    public Warrior()
    {
        AttackPower = 25;
    }

    public Warrior(string name, float maxHealth)
    {
        AttackPower = 25;
    }

    public void DoubleHit(Character target)
    {
        Health -= 10;
        target.Health -= AttackPower * 2;
    }

    public int GetPower()
    {
        return AttackPower;
    }
}
