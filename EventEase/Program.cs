using EventEase.Data;

var builder = WebApplication.CreateBuilder(args);

// Add Razor Pages and Blazor
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Register your custom services
builder.Services.AddScoped<SessionState>();
builder.Services.AddSingleton<EventService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
