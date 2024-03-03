using BooberBreakfast.Services.CacheServices;
using BooberBreakfast.Services.PersonServices;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    // builder.Services.AddScoped<IPersonService, PersonService>();
    builder.Services.AddScoped<IPersonService, PersonServiceList>();
    builder.Services.AddScoped<ICacheService, RedisCacheService>();
}

var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
