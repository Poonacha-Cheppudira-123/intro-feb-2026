using Scalar.Aspire;

var builder = DistributedApplication.CreateBuilder(args);

// Infrastructure - "backing services" - what is my app going to need in the environment in which it runs.

var scalar = builder.AddScalarApiReference();
// - database - postgres (great support for relational data (rows and columns) and for documents (like mongodb))
// - identity provider (later)
var postGres = builder.AddPostgres("db-server")
    .WithLifetime(ContainerLifetime.Persistent); // we have in production a postgres server

// we are going to need a database on that server for the API

var mmDb = postGres.AddDatabase("db-mm");



var mmApi = builder.AddProject<Projects.MuddiestMoment_Api>("mm-api")
    .WithReference(mmDb)
    .WaitFor(mmDb);

scalar.WithApiReference(mmApi);

var gateway = builder.AddProject<Projects.Gateway_Api>("gateway")
    .WithReference(mmApi)
    .WaitFor(mmApi);

builder.Build().Run();
