public class WeaponBuilder
{
    public string? Rarity;
    public string? DefaultName;
    public string[]? Properties;
    public WeaponDamage? BaseDamage;
    public int? EffectiveRange;
    public int? IneffectiveRange;
    public string? Name;
    public WeaponDamage? ExtraDamage;
    public WeaponEffect? WeaponEffect;

    public WeaponBuilder SetRarity(string rarity)
    {
        this.Rarity = rarity;

        return this;
    }

    public WeaponBuilder SetMundaneWeaponProperties(MundaneWeapon mundaneWeapon)
    {
        this.DefaultName = mundaneWeapon.Name;
        this.Properties = mundaneWeapon.Properties;
        this.BaseDamage = mundaneWeapon.BaseDamage;
        this.EffectiveRange = mundaneWeapon.EffectiveRange;
        this.IneffectiveRange = mundaneWeapon.IneffectiveRange;

        return this;
    }

    public WeaponBuilder SetName(string name)
    {
        this.Name = name;

        return this;
    }

    public WeaponBuilder SetExtraDamage(WeaponDamage weaponDamage)
    {
        this.ExtraDamage = weaponDamage;

        return this;
    }

    public WeaponBuilder SetWeaponEffect(WeaponEffect weaponEffect)
    {
        this.WeaponEffect = weaponEffect;

        return this;
    }

    public Weapon Build()
    {
        if (Rarity != null
            && DefaultName != null
            && Properties != null
            && BaseDamage != null
            && EffectiveRange is int effectiveRange
            && IneffectiveRange is int ineffectiveRange
            && ExtraDamage != null
            && WeaponEffect != null
        ) {
            return new Weapon(
                0,
                DefaultName,
                Name,
                Rarity,
                Properties,
                BaseDamage,
                ExtraDamage,
                WeaponEffect,
                effectiveRange,
                ineffectiveRange
            );
        } else {
            throw new ArgumentException("Cannot generate weapon!");
        }
    }
}