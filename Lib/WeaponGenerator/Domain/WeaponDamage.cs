public class WeaponDamage
{
    public int DiceCount { get; set; }
    public int DiceType { get; set; }
    public string DamageType { get; set; }

    public WeaponDamage(int diceCount, int diceType, string damageType)
    {
        this.DiceCount = diceCount;
        this.DiceType = diceType;
        this.DamageType = damageType;
    }
}