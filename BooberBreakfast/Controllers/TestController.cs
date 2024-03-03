using BooberBreakfast.Models;
using BooberBreakfast.Services.CacheServices;
using BooberBreakfast.Services.PersonServices;
using Microsoft.AspNetCore.Mvc;

namespace BooberBreakfast.Contracts.Breakfast;

[ApiController]
public class TestController : ControllerBase
{
    private IPersonService personService;
    private ICacheService cache;

    public TestController(IPersonService personService, ICacheService cache)
    {
        this.personService = personService;
        this.cache = cache;
    }

    [HttpGet("/test")]
    public IActionResult GetTest(TestRequest request)
    {
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


    [HttpPost("/test/cache")]
    public IActionResult PostKeyValue(PostKeyValueRequest request)
    {
        cache.SetValue(request.key, request.value);
        return Ok(request);
    }

    [HttpGet("/test/cache/{name}")]
    public IActionResult GetKeyValue(string name)
    {
        string val = cache.GetValue(name);
        PostKeyValueResponse res = new PostKeyValueResponse(val);
        return Ok(res);
    }
}
