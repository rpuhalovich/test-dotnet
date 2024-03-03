using BooberBreakfast.Models;
using Microsoft.VisualBasic;

namespace BooberBreakfast.Services.PersonServices;

public class PersonService : IPersonService {
	private Dictionary<string, Person> persondict = new Dictionary<string, Person>();

    public void AddPerson(Person person) {
        persondict.Add(person.name, person);
    }

    public Person GetPerson(string name) {
        return persondict[name];
    }
}
