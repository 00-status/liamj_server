public class GenerateWeaponService
{
    private readonly Random Random;
    private readonly MundaneWeaponContext MundaneWeaponContext;
    private readonly WeaponEffectDBContext WeaponEffectDBContext;

    public GenerateWeaponService(WeaponEffectDBContext weaponEffectDBContext)
    {
        Random = new();
        MundaneWeaponContext = new();
        this.WeaponEffectDBContext = weaponEffectDBContext;
    }

    public IResult GenerateWeapon()
    {
        WeaponBuilder builder = new();

        MundaneWeapon randomMundaneWeapon = PickMundaneWeapon();
        ExtraDamage extraDamage = PickExtraDamage();

        List<WeaponEffect> weapons = WeaponEffectDBContext.WeaponEffects.ToList();
        int randomIndex = Random.Next(weapons.Count);
        WeaponEffect randomWeaponEffect = weapons[randomIndex];

        Weapon generatedWeapon = builder
            .SetRarity("Uncommon")
            .SetMundaneWeaponProperties(randomMundaneWeapon)
            .SetExtraDamage(extraDamage.WeaponDamage)
            .SetWeaponEffect(randomWeaponEffect)
            .Build();

        return Results.Ok(generatedWeapon);

        // Instantiates a new builder. ✅
        // Randomly picks a base weapon. ✅
        // Adds base weapon properties to builder. ✅
        // randomly picks extra damage. ✅
        // Fetches WeaponEffects from the DB. ✅
        // randomly picks a WeaponEffect. ✅
        // Call Google Gemini to generate name.
        // Select traits on each step based on rarity.
        // Build the new weapon. ✅
        // Save the built weapon to the DB.
        // return the new weapon through the API. ✅
    }

    private MundaneWeapon PickMundaneWeapon()
    {
        int randomIndex = Random.Next(MundaneWeaponContext.MundaneWeapons.Count);
        return MundaneWeaponContext.MundaneWeapons[randomIndex];
    }

    private ExtraDamage PickExtraDamage()
    {
        int randomIndex = Random.Next(MundaneWeaponContext.ExtraDamages.Count());
        return MundaneWeaponContext.ExtraDamages[randomIndex];
    }
}