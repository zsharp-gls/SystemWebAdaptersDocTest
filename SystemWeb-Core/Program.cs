
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSystemWebAdapters()
    .AddJsonSessionSerializer(options => ClassLibrary.SessionUtils.RegisterSessionKeys(options.KnownKeys))
    .WrapAspNetCoreSession()
    .AddRemoteAppClient(options =>
    {
        options.RemoteAppUrl = new(builder.Configuration["ReverseProxy:Clusters:fallbackCluster:Destinations:fallbackApp:Address"]);
        options.ApiKey = builder.Configuration["RemoteAppApiKey"];
    })
    .AddAuthenticationClient(isDefaultScheme: true);

builder.Services.AddReverseProxy().LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();
app.UseSystemWebAdapters();

app.MapDefaultControllerRoute();
app.MapReverseProxy();

app.Run();
