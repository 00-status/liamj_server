using Microsoft.EntityFrameworkCore;

public class ListWeaponEffectService
{
    private readonly WeaponEffectDBContext DbContext;

    public ListWeaponEffectService(WeaponEffectDBContext weaponEffectDBContext)
    {
        DbContext = weaponEffectDBContext;
    }

    public async Task<IResult> ListWeaponEffects()
    {
        return Results.Ok(await this.DbContext.WeaponEffects.ToListAsync());
    }
}