namespace BooberBreakfast.Contracts.Breakfast;

public record CreateBreakfastRequest(
	string Name,
	string Description,
	DateTime Start,
	DateTime End,
	List<string> Savory,
	List<string> Sweet
);
