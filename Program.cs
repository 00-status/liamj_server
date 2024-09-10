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


app.MapGet("/api/1/weapon_effects", (ListWeaponEffectService service) => service.ListWeaponEffects());
app.MapPost(
    "/api/1/weapon_effects",
    (SaveWeaponEffectService service, WeaponEffect weaponEffect) => service.SaveWeapon(weaponEffect)
);

app.UseStaticFiles();
app.UseRouting();
app.UseSpa(spa => { });

app.Run();

app.Run();
