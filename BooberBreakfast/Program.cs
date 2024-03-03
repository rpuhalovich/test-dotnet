using BooberBreakfast.Services.PersonServices;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    builder.Services.AddControllers();
    builder.Services.AddScoped<IPersonService, PersonService>();
}

var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
