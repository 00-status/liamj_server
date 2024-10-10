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

    public async Task<IResult> GenerateWeapon(string rarity)
    {
        MundaneWeapon randomMundaneWeapon = PickMundaneWeapon();
        ExtraDamage extraDamage = PickExtraDamage(rarity);
        WeaponEffect randomWeaponEffect = PickWeaponEffect(rarity);

        List<string> tagList = new([.. extraDamage.Tags, .. randomWeaponEffect.Tags]);

        List<string> refinedList = new();
        for (int i = 0; i < 2; i++) {
            int randomIndex = Random.Next(tagList.Count);

            refinedList.Add(tagList[randomIndex]);
        }

        string? weaponName = await GoogleGeminiApiClient.GenerateWeaponName(
            randomMundaneWeapon.Name,
            refinedList
        );

        WeaponBuilder builder = new WeaponBuilder()
            .SetRarity(rarity)
            .SetMundaneWeaponProperties(randomMundaneWeapon)
            .SetExtraDamage(extraDamage.WeaponDamage)
            .SetWeaponEffect(randomWeaponEffect);

        if (weaponName != null) {
            builder.SetName(weaponName);
        }

        return Results.Ok(builder.Build());
    }

    private MundaneWeapon PickMundaneWeapon()
    {
        int randomIndex = Random.Next(MundaneWeaponContext.MundaneWeapons.Count);
        return MundaneWeaponContext.MundaneWeapons[randomIndex];
    }

    private ExtraDamage PickExtraDamage(string rarity)
    {
        List<ExtraDamage> filteredExtraDamages = MundaneWeaponContext.ExtraDamages.FindAll(extraDamage => {
            return extraDamage.RarityLevels.ToList().Contains(rarity);
        });

        int randomIndex = Random.Next(filteredExtraDamages.Count());
        return filteredExtraDamages[randomIndex];
    }

    private WeaponEffect PickWeaponEffect(string rarity)
    {
        List<WeaponEffect> weaponEffects = WeaponEffectDBContext.WeaponEffects.ToList();

        List<WeaponEffect> filteredWeaponEffects = weaponEffects.FindAll(weaponEffect => {
            return weaponEffect.Rarities.ToList().Contains(rarity);
        });

        int randomIndex = Random.Next(filteredWeaponEffects.Count);
        return filteredWeaponEffects[randomIndex];
    }
}
