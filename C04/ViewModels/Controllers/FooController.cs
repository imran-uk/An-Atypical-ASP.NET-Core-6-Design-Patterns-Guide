using Microsoft.AspNetCore.Mvc;

namespace ViewModels.Controllers;

public class FooController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get() => default!;
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id) => default!;
    [HttpPost]
    public void Post([FromBody] string value) { }
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value) { }
    [HttpDelete("{id}")]
    public void Delete(int id) { }
}