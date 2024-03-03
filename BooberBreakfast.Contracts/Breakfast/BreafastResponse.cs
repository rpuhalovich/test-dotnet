namespace BooberBreakfast.Contracts.Breakfast;

public record BreakfastResponse(
	Guid Id,
	string Name,
	string Description,
	DateTime Start,
	DateTime End,
	DateTime LastModified,
	List<string> Savory,
	List<string> Sweet
);
