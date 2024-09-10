public class SaveWeaponEffectService
{
    private readonly WeaponEffectDBContext WeaponEffectDBContext;

    public SaveWeaponEffectService(WeaponEffectDBContext weaponEffectDBContext)
    {
        this.WeaponEffectDBContext = weaponEffectDBContext;
    }

    public async Task<IResult> SaveWeapon(WeaponEffect weaponEffect)
    {
        this.WeaponEffectDBContext.Add(weaponEffect);
        await this.WeaponEffectDBContext.SaveChangesAsync();

        return Results.Created($"/weapon_effects", weaponEffect);
    }
}
