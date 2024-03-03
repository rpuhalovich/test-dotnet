namespace BooberBreakfast.Services.CacheServices;

public interface ICacheService
{
    public void SetValue(string key, string value);
    public string GetValue(string key);
}
