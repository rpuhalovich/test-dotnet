namespace BooberBreakfast.Contracts.Breakfast;

public record GetPersonRequest(
	string name,
	int age
);

public record GetPersonResponse(
	string name,
	int age
);
