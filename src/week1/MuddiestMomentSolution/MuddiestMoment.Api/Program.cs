// [X] Use Top Level Statements

using Marten;
using MuddiestMoment.Api.Student;

var builder = WebApplication.CreateBuilder(args);


var connectionString = builder.Configuration.GetConnectionString("db-mm") ?? throw new Exception("No Connection String");


builder.Services.AddMarten(config =>
{
    config.Connection(connectionString);
}).UseLightweightSessions();

builder.AddServiceDefaults();
// Add the services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// above this is configuration of services (things that own some state and the process around it) that we need in our
// application.
builder.Services.AddValidation(); // opting in to services to handle some stuff for you.
var app = builder.Build();
// everything here is setting up how we actually handle incoming request and write responses.

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi(); // while I'm doing development, I want to GET the document at /openapi/v1.json
    // it will generate this when you ask for it. Slow. But "accurate", right?
}
// add the code I am about to write that allows us to handle POST to /student/m

app.MapStudentEndpoints(); // More explicit - means more "intention revealing"


app.MapDefaultEndpoints();

// the api is not up and running (listening for requests until we hit the next line)
app.Run(); // "blocking loop"



