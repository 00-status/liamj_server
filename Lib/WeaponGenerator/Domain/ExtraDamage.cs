public class ExtraDamage
{
    public WeaponDamage WeaponDamage { get; set; }
    public string[] RarityLevels { get; set; }
    public string[] Tags { get; set; }
    
    public ExtraDamage(WeaponDamage weaponDamage, string[] rarityLevels, string[] tags)
    {
        this.WeaponDamage = weaponDamage;
        this.RarityLevels = rarityLevels;
        this.Tags = tags;
    }
}