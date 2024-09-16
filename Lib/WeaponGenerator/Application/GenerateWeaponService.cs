public class GenerateWeaponService
{
    private readonly MundaneWeaponContext MundaneWeaponContext;
    private readonly WeaponEffectDBContext WeaponEffectDBContext;

    public GenerateWeaponService(WeaponEffectDBContext weaponEffectDBContext)
    {
        MundaneWeaponContext = new();
        this.WeaponEffectDBContext = weaponEffectDBContext;
    }

    public IResult GenerateWeapon()
    {
        WeaponBuilder builder = new();

        MundaneWeapon randomMundaneWeapon = PickMundaneWeapon();

        Random random = new();
        int randomIndex = random.Next(MundaneWeaponContext.ExtraDamages.Count());
        ExtraDamage extraDamage = MundaneWeaponContext.ExtraDamages[randomIndex];

        Weapon generatedWeapon = builder
            .SetRarity("Uncommon")
            .SetMundaneWeaponProperties(randomMundaneWeapon)
            .SetExtraDamage(extraDamage.WeaponDamage)
            .Build();

        return Results.Ok(generatedWeapon);

        // Instantiates a new builder. ✅
        // Randomly picks a base weapon. ✅
        // Adds base weapon properties to builder. ✅
        // randomly picks extra damage. ✅
        // Fetches WeaponEffects from the DB.
        // randomly picks a WeaponEffect.
        // Build the new weapon. ✅
        // return the new weapon through the API. ✅
        // Select traits on each step based on rarity.
    }

    private MundaneWeapon PickMundaneWeapon()
    {
        Random random = new();

        int randomIndex = random.Next(MundaneWeaponContext.MundaneWeapons.Count);

        return MundaneWeaponContext.MundaneWeapons[randomIndex];
    }
}