namespace BooberBreakfast.Contracts.Breakfast;

public record GetKeyValueNotFoundResponse(
    string message
);

public record GetKeyValueResponse(
    string value
);
