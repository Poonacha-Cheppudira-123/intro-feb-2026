using Alba;
using MuddiestMoment.Api.Student.Endpoints;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.WebRequestMethods;

namespace MuddiestMoment.Tests.students;

public class AddsMoment
{
    [Fact]
    public async Task CanAddAMoment()
    {
        var host = await AlbaHost.For<Program>();

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
