using System.Text;
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

var app = builder.Build();

app.MapGet(
    "/api/1/test",
    async () => {
        if (GAK == null) {
            return "No GAK :(";
        }

        string URI = "https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash:generateContent?key=" + GAK;
        string body = "{ \"contents\": [{\"parts\": [{\"text\": \"Generate an evocative fantasy name for a longsword-type weapon. It should be 1-5 words. Use some of the following tags: { holy, fire, obsidian, speed }. Do not generate a preamble or explanation - just generate the name itself. Thanks!\" }] }] }";

        HttpRequestMessage request = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri(URI),
            Content = new StringContent(body, Encoding.UTF8, "application/json")
        };

        HttpClient httpClient = new();
        HttpResponseMessage response = await httpClient.SendAsync(request);

        return await response.Content.ReadAsStringAsync();
    }
);
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
