public class ExtraDamage
{
    public WeaponDamage WeaponDamage { get; set; }
    public string[] RarityLevels { get; set; }
    
    public ExtraDamage(WeaponDamage weaponDamage, string[] rarityLevels)
    {
        this.WeaponDamage = weaponDamage;
        this.RarityLevels = rarityLevels;
    }
}