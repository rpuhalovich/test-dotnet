using NRedisStack;
using NRedisStack.RedisStackCommands;
using StackExchange.Redis;

using BooberBreakfast.Services.CacheServices;

public class RedisCacheService : ICacheService
{
    private IDatabase db;

    public RedisCacheService()
    {
        ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost");
        db = redis.GetDatabase();
    }

    public string GetValue(string key)
    {
        string res = db.StringGet(key);
        if (res == null) throw new Exception("key not found");
        return res;
    }

    public void SetValue(string key, string value)
    {
        db.StringSet(key, value);
    }
}
