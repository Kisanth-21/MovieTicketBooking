using MovieTicket_UI.Components;
using MovieTicket.UI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddScoped<MovieApiService>();
builder.Services.AddScoped<BookingApiService>();

builder.Services.AddScoped(sp =>
    new HttpClient
    {
        BaseAddress = new Uri("http://localhost:5258/")
    });

var app = builder.Build();


app.UseStaticFiles();
app.UseRouting();
app.UseAntiforgery();


app.MapRazorComponents<App>()
   .AddInteractiveServerRenderMode();

app.Run();
