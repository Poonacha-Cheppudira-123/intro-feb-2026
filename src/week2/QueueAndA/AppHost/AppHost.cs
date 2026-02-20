var builder = DistributedApplication.CreateBuilder(args);

var pg = builder.AddPostgres("pg", port: 5432).WithImage("postgres:17.5")
    .WithLifetime(ContainerLifetime.Session);

var qaDb = pg.AddDatabase("qa-db");


var qaApi = builder.AddProject<Projects.Qa_Api>("qa-api")
    .WithReference(qaDb)
    .WaitFor(qaDb);

var bff = builder.AddProject<Projects.BackendForFrontend>("bff")
    .WithReference(qaApi)
    .WaitFor(qaApi);

builder.Build().Run();