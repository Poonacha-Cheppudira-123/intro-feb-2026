using Marten;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.AddServiceDefaults();
builder.Services.AddOpenApi();
builder.AddNpgsqlDataSource("qa-db");

builder.Services.AddMarten(options =>
{

}).UseNpgsqlDataSource();

var app = builder.Build();

app.MapGet("/greeting", () => "Hello World!"); // TODO: Remove this when you add real endpoints
app.MapControllers();
app.MapOpenApi();
app.MapDefaultEndpoints();
app.Run(); 