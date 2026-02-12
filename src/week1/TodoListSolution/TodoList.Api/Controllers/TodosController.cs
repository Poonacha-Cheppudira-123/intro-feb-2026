using Microsoft.AspNetCore.Mvc;

namespace TodoList.Api.Controllers;

public class TodosController : ControllerBase
{
    // When they a get request /todos
    [HttpGet("/todos")]
    public async Task<ActionResult> GetAllTodos()
    {
        
        return Ok(new List<string> {  "Clean The Garage", "Take Out The Trash"});
    }
    // GET /todos/{id}

    // POST /

    // PUT /todos/{id}/person
}
