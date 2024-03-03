using BooberBreakfast.Models;
using BooberBreakfast.Services.PersonServices;
using Microsoft.AspNetCore.Mvc;

namespace BooberBreakfast.Contracts.Breakfast;

[ApiController]
public class TestController : ControllerBase
{
    private IPersonService personService;

    public TestController(IPersonService personService)
    {
        this.personService = personService;
    }

    [HttpGet("/test")]
    public IActionResult GetTest(TestRequest request)
    {
		Console.WriteLine("hello there");
        return Ok(request);
    }

    [HttpPost("/test/person")]
    public IActionResult PostPerson(PostPersonRequest request)
    {
        Person person = new Person(request.name, request.age);
        personService.AddPerson(person);
        return Ok(request);
    }

    [HttpGet("/test/person/{name}")]
    public IActionResult GetPerson(GetPersonRequest request)
    {
        Person resultPerson = personService.GetPerson(request.name);
        GetPersonResponse res = new GetPersonResponse(resultPerson.name, resultPerson.age);
        return Ok(res);
    }
}
