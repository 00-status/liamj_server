var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();


app.MapGet("/api/test", () => "Hello API");

app.UseStaticFiles(new StaticFileOptions() {});
app.UseRouting();
app.UseSpa(spa => { });

app.Run();

app.Run();
