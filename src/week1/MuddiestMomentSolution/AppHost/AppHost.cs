var builder = DistributedApplication.CreateBuilder(args);

// Infrastructure - "backing services" = what is my app going to need in the environment in which it runs?.
// - database - postgres
var postGres = builder.AddPostgres("pg-server")
    .WithLifetime(ContainerLifetime.Persistent); // Set up a PostGres server

var mmDb = postGres.AddDatabase("db-mm"); // Add a database on the server for our API

var mmApi = builder.AddProject<Projects.MuddiestMoment_Api>("mm-api")
    .WithReference(mmDb)
    .WaitFor(mmDb);

var gateway = builder.AddProject<Projects.Gateway_Api>("gateway")
    .WithReference(mmApi)
    .WaitFor(mmApi);

builder.Build().Run();
