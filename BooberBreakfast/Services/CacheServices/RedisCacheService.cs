using NRedisStack;
using NRedisStack.RedisStackCommands;
using StackExchange.Redis;

using BooberBreakfast.Services.CacheServices;

public class RedisCacheService : ICacheService
{
    private IDatabase db;

    public RedisCacheService(string serviceUrl)
    {
        ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(serviceUrl);
        if (!redis.IsConnected) throw new Exception("redis not running");
        db = redis.GetDatabase();
        if (db == null) throw new Exception("redis not connected");
    }

    public string GetValue(string key)
    {
        RedisValue res = db.StringGet(key);
        if (!res.HasValue) throw new Exception("key not found");
        return res.ToString();
    }

    public void SetValue(string key, string value)
    {
        db.StringSet(key, value);
    }
}
