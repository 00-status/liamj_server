public class Weapon
{
    public int Id { get; set; }
    public string DefaultName { get; set; }
    public string? Name { get; set; }
    public string Rarity { get; set; }
    public string[] Properties { get; set; }
    public WeaponDamage BaseDamage { get; set; }
    public WeaponDamage ExtraDamage { get; set; }
    public WeaponEffect WeaponEffect { get; set; }
    public int EffectiveRange { get; set; }
    public int IneffectiveRange { get; set; }

    public Weapon(
        int id,
        string defaultName,
        string? name,
        string rarity,
        string[] properties,
        WeaponDamage baseDamage,
        WeaponDamage extraDamage,
        WeaponEffect weaponEffect,
        int effecttiveRange,
        int ineffectiveRange
    ) {
        this.Id = id;
        this.DefaultName = defaultName;
        this.Name = name;
        this.Rarity = rarity;
        this.Properties = properties;
        this.BaseDamage = baseDamage;
        this.ExtraDamage = extraDamage;
        this.WeaponEffect = weaponEffect;
        this.EffectiveRange = effecttiveRange;
        this.IneffectiveRange = ineffectiveRange;
    }
}
