public class MundaneWeapon
{
    public string Name { get; set; }
    public string[] Properties { get; set; }
    public WeaponDamage BaseDamage { get; set; }
    public int EffectiveRange { get; set; }
    public int IneffectiveRange { get; set; }

    public MundaneWeapon(
        string name,
        string[] properties,
        WeaponDamage baseDamage,
        int effecttiveRange,
        int ineffectiveRange
    ) {
        this.Name = name;
        this.Properties = properties;
        this.BaseDamage = baseDamage;
        this.EffectiveRange = effecttiveRange;
        this.IneffectiveRange = ineffectiveRange;
    }
}
