using BooberBreakfast.Models;
using Microsoft.VisualBasic;

namespace BooberBreakfast.Services.PersonServices;

public class PersonServiceList : IPersonService
{
    private List<Person> personlist = new List<Person>();

    public void AddPerson(Person person)
    {
        personlist.Add(person);
    }

    public Person GetPerson(string name)
    {
        var person = personlist.Find(e => e.name == name);
        if (person == null) throw new Exception("person not found");
        return person;
    }
}
