using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<WeaponEffectDBContext>(options => {
    var partialConnectionString = builder.Configuration.GetConnectionString("PostgreSqlDatabase");
    partialConnectionString += builder.Configuration["PostgresNamePass"];

    options.UseNpgsql(partialConnectionString);
});

builder.Services.AddScoped<ListWeaponEffectService>();
builder.Services.AddScoped<SaveWeaponEffectService>();

var app = builder.Build();

app.MapGet(
    "/api/1/weapon_effects",
    (ListWeaponEffectService service) => service.ListWeaponEffects()
);
app.MapPost(
    "/api/1/weapon_effects",
    (SaveWeaponEffectService service, WeaponEffect weaponEffect) => service.SaveWeapon(weaponEffect)
);

// Builder class
//      Instantiates a weapon's base properties.
//      Randomly picks extra damage based on rarity.
//      Randomly picks an Action based on rarity.
//          Actions are retrieved from the DB.
// Call Google's Gemini 2 API to generate an evocative name.
// Save the completed weapon to the DB.
// Return generated weapon.


app.UseStaticFiles();
app.UseRouting();
app.UseSpa(spa => { });

app.Run();
