
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(); // add the services for activating and handling controllers - a ton of them.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// "Native" (non - runtime, no JVM, no CLR) - start up time.
// Some APIs are started on demand. So-called "Serverless"
//  Amazon Lambda, Azure Function, KNative, etc.

app.MapControllers(); // This line - Use Reflection to find all the controllers and create the routing table.
// "While the code is running, have some code that looks at itself (reflects)."
// GET /todos -> Create an Instance of the TodosController Class, Call the GetAllTodosMethod

app.Run();