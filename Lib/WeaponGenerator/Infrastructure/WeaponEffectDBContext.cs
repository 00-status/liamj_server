using Microsoft.EntityFrameworkCore;

public class WeaponEffectDBContext: DbContext
{
    public DbSet<WeaponEffect> WeaponEffects { get; set; }

    public WeaponEffectDBContext(DbContextOptions<WeaponEffectDBContext> options): base(options)
    {
    }
}

