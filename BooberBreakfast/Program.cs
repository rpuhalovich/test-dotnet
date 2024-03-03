using BooberBreakfast.Services.CacheServices;
using BooberBreakfast.Services.PersonServices;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    // builder.Services.AddSingleton<IPersonService, PersonService>();
    builder.Services.AddSingleton<IPersonService, PersonServiceList>();
    builder.Services.AddSingleton<ICacheService, RedisCacheService>(x => new RedisCacheService("localhost"));
}

var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
