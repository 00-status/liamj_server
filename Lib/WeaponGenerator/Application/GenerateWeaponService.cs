public class GenerateWeaponService
{
    private readonly WeaponEffectDBContext WeaponEffectDBContext;

    public GenerateWeaponService(WeaponEffectDBContext weaponEffectDBContext)
    {
        this.WeaponEffectDBContext = weaponEffectDBContext;
    }

    public IResult GenerateWeapon()
    {
        WeaponBuilder builder = new();

        MundaneWeapon randomMundaneWeapon = PickMundaneWeapon();

        Weapon generatedWeapon = builder
            .SetRarity("Uncommon")
            .SetMundaneWeaponProperties(randomMundaneWeapon)
            .SetExtraDamage(new WeaponDamage(1, 6, "Slashing"))
            .Build();

        return Results.Ok(generatedWeapon);

        // Instantiates a new builder. ✅
        // Randomly picks a base weapon. ✅
        // Adds base weapon properties to builder. ✅
        // randomly picks extra damage based on rarity.
        // Fetches WeaponEffects from the DB.
        // randomly picks a WeaponEffect based on rarity.
        // Build the new weapon. ✅
        // return the new weapon through the API. ✅
    }

    private static MundaneWeapon PickMundaneWeapon()
    {
        MundaneWeaponContext mundaneWeaponContext = new();
        Random random = new();

        int randomIndex = random.Next(mundaneWeaponContext.MundaneWeapons.Count);

        return mundaneWeaponContext.MundaneWeapons[randomIndex];
    }
}