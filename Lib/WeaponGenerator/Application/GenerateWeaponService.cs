public class GenerateWeaponService
{
    private readonly Random Random;
    private readonly MundaneWeaponContext MundaneWeaponContext;
    private readonly WeaponEffectDBContext WeaponEffectDBContext;
    private readonly GoogleGeminiApiClient GoogleGeminiApiClient;

    public GenerateWeaponService(
        WeaponEffectDBContext weaponEffectDBContext,
        GoogleGeminiApiClient googleGeminiApiClient
    ) {
        Random = new();
        MundaneWeaponContext = new();
        this.WeaponEffectDBContext = weaponEffectDBContext;
        this.GoogleGeminiApiClient = googleGeminiApiClient;
    }

    public async Task<IResult> GenerateWeapon()
    {
        WeaponBuilder builder = new();

        MundaneWeapon randomMundaneWeapon = PickMundaneWeapon();
        ExtraDamage extraDamage = PickExtraDamage();
        WeaponEffect randomWeaponEffect = PickWeaponEffect();

        string weaponName = await GoogleGeminiApiClient.GenerateWeaponName(
            randomMundaneWeapon.Name,
            new List<string>(extraDamage.Tags)
        );

        Weapon generatedWeapon = builder
            .SetRarity("Uncommon")
            .SetMundaneWeaponProperties(randomMundaneWeapon)
            .SetExtraDamage(extraDamage.WeaponDamage)
            .SetWeaponEffect(randomWeaponEffect)
            .SetName(weaponName)
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

    private WeaponEffect PickWeaponEffect()
    {
        List<WeaponEffect> weapons = WeaponEffectDBContext.WeaponEffects.ToList();
        int randomIndex = Random.Next(weapons.Count);
        WeaponEffect randomWeaponEffect = weapons[randomIndex];
        return randomWeaponEffect;
    }
}
