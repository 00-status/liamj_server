using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

public class WeaponEffectDBContext: DbContext
{
    public DbSet<WeaponEffect> WeaponEffects { get; set; }

    public WeaponEffectDBContext(DbContextOptions<WeaponEffectDBContext> options): base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WeaponEffect>().ToTable("weapon_effects");
        modelBuilder.Entity<WeaponEffect>().Property(weaponEffect => weaponEffect.Id).HasColumnName("id");
        modelBuilder.Entity<WeaponEffect>().Property(weaponEffect => weaponEffect.Name).HasColumnName("name");
        modelBuilder.Entity<WeaponEffect>().Property(weaponEffect => weaponEffect.Description).HasColumnName("description");
        modelBuilder.Entity<WeaponEffect>().Property(weaponEffect => weaponEffect.Rarities).HasColumnName("rarities");
        modelBuilder.Entity<WeaponEffect>().Property(weaponEffect => weaponEffect.Tags).HasColumnName("tags");
    }
}

