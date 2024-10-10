using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string? GAK = builder.Configuration["GAK"];

builder.Services.AddDbContext<WeaponEffectDBContext>(options => {
    var partialConnectionString = builder.Configuration.GetConnectionString("PostgreSqlDatabase");
    partialConnectionString += builder.Configuration["PostgresNamePass"];

    options.UseNpgsql(partialConnectionString);
});

builder.Services.AddScoped<GenerateWeaponService>();
builder.Services.AddScoped<ListWeaponEffectService>();
builder.Services.AddScoped<SaveWeaponEffectService>();

builder.Services.AddScoped<GoogleGeminiApiClient>();

var app = builder.Build();

// TODO:
//      Only build weapon_effects API endpoints in dev mode. ✅
//      Replace strings with enums.
//      Save the built weapon to the DB.
//      Add ranged weapons to mundaneWeapon context. ✅
//      Add 5e 2024 weapon mastery abilities. ✅
//      Make a more complete additionalDamage list. ✅
//      fix Candidate null API error.

app.MapGet(
    "/api/1/generate_weapon",
    (GenerateWeaponService service, string? rarity) => service.GenerateWeapon(rarity ?? "Uncommon")
);

if (app.Environment.IsDevelopment()) {
    app.MapGet(
        "/api/1/weapon_effects",
        (ListWeaponEffectService service) => service.ListWeaponEffects()
    );
    app.MapPost(
        "/api/1/weapon_effects",
        (SaveWeaponEffectService service, WeaponEffect weaponEffect) => service.SaveWeapon(weaponEffect)
    );
}

app.UseStaticFiles();
app.UseRouting();
app.UseSpa(spa => { });

app.Run();
