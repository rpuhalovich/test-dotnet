using BooberBreakfast.Models;

namespace BooberBreakfast.Services.PersonServices;

public interface IPersonService {
	public Person GetPerson(string name);
	public void AddPerson(Person person);
}
