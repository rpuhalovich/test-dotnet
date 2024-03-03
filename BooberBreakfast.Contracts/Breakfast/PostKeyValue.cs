namespace BooberBreakfast.Contracts.Breakfast;

public record PostKeyValueRequest(
    string key,
    string value
);

public record PostKeyValueResponse(
    string value
);
