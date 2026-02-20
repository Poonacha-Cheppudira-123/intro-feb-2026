using BackendForFrontend;
using Duende.AccessTokenManagement.OpenIdConnect;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();
builder.AddBffYarpReverseProxy();
builder.AddAuthenticationSchemes();
builder.Services.AddOpenIdConnectAccessTokenManagement();
builder.Services.AddProblemDetails();

var app = builder.Build();
app.UseAuthentication();
app.UseAuthorization();

app.MapReverseProxy();
app.MapDefaultEndpoints();
app.Run();