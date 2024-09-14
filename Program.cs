using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<WeaponEffectDBContext>(options => {
    var partialConnectionString = builder.Configuration.GetConnectionString("PostgreSqlDatabase");
    partialConnectionString += builder.Configuration["PostgresNamePass"];

    options.UseNpgsql(partialConnectionString);
});

builder.Services.AddScoped<GenerateWeaponService>();
builder.Services.AddScoped<ListWeaponEffectService>();
builder.Services.AddScoped<SaveWeaponEffectService>();

var app = builder.Build();


app.MapGet(
    "/api/1/generate_weapon",
    (GenerateWeaponService service) => service.GenerateWeapon()
);
app.MapGet(
    "/api/1/weapon_effects",
    (ListWeaponEffectService service) => service.ListWeaponEffects()
);
app.MapPost(
    "/api/1/weapon_effects",
    (SaveWeaponEffectService service, WeaponEffect weaponEffect) => service.SaveWeapon(weaponEffect)
);


// GenerateWeaponService
//      Instantiates a new builder.
//      Randomly picks a base weapon.
//      Adds base weapon properties to builder.
//      randomly picks extra damage based on rarity.
//      Fetches WeaponActions from the DB.
//      randomly picks a WeaponAction based on rarity.
//      Build the new weapon.
//      return the new weapon through the API.

// Builder class
//      Instantiates a weapon's base properties.
//      Randomly picks extra damage based on rarity.
//      Randomly picks a WeaponAction based on rarity.
//          WeaponActions are retrieved from the DB.
// Call Google's Gemini 2 API to generate an evocative name.
// Add the evocative name to the builder.
// Build the new Weapon.
// Save the completed Weapon to the DB.
// Return the generated Weapon in the API response.

app.UseStaticFiles();
app.UseRouting();
app.UseSpa(spa => { });

app.Run();
