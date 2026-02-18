using Alba;
using Microsoft.Extensions.DependencyInjection;
using MuddiestMoment.Api.Student.Endpoints;
using NSubstitute;
using Testcontainers.PostgreSql;

namespace MuddiestMoment.Tests.students;

public class AddsMoment
{
    [Fact]
    public async Task CanAddAMoment()
    {
        // starting up container which as our postgres db - notice the version
        var postgreSqlContainer = new PostgreSqlBuilder("postgres:17.5").Build();
        await postgreSqlContainer.StartAsync();

        var stubbedUserProvider = Substitute.For<IProvideUserInformation>();
        stubbedUserProvider.GetUserId().Returns("TEST-USER");
        // Start up my API
        var host = await AlbaHost.For<Program>(config =>
        {
            // Example 1 of "gray box testing"
            config.UseSetting("ConnectionStrings:db-mm", postgreSqlContainer.GetConnectionString());
            config.ConfigureServices(sp =>
            {
                // sp.AddScoped<IProvideUserInformation>((_) => stubbedUserProvider);
                sp.AddScoped<IProvideUserInformation>((_) => stubbedUserProvider);
            });
        });

        // Scenario
        // Start up the API
        // Make a post request with some data to /student/moments
        // the status code should be a 200.
        // We should also get some stuff back.
        // Part 2 later.

        var itemToSend = new StudentMomentCreateModel
        {
            Title = "Containers",
            Description = "Tell me about volumes"
        };

        var response = await host.Scenario(api =>
        {
            // Fluent Interface - a "Domain Specific Language"
            api.Post.Json(itemToSend).ToUrl("/student/moments");
            api.StatusCodeShouldBeOk();
        });
    }
}

/*
POST https://localhost:1337/student/moments 
Content-Type: application/json
Authorization: Bearer ???? (Fake this for while)

{
    "title": "Containers",
    "description": "Tell me about volumes"
}

dotnet run // start the api

dotnet test // run my system tests
*/
