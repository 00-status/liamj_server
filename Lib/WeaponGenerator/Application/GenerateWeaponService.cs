public class GenerateWeaponService
{
    private readonly WeaponEffectDBContext WeaponEffectDBContext;

    public GenerateWeaponService(WeaponEffectDBContext weaponEffectDBContext)
    {
        this.WeaponEffectDBContext = weaponEffectDBContext;
    }

    public Task<IResult> generateWeapon()
    {

        // Instantiates a new builder.
        // Randomly picks a base weapon.
        // Adds base weapon properties to builder.
        // randomly picks extra damage based on rarity.
        // Fetches WeaponActions from the DB.
        // randomly picks a WeaponAction based on rarity.
        // Build the new weapon.
        // return the new weapon through the API.

        throw new NotImplementedException();
    }
}