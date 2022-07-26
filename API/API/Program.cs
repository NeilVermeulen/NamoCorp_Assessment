using DAL.DataAccess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddSingleton<ITelephoneNumberTypesCache, TelephoneNumberTypesCache>();

builder.Services.AddDbContext<DataContext>(o =>
{
    o.UseSqlServer(builder.Configuration.GetConnectionString("NamoCorp"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

#region Microservices

#region Addresses

app.MapGet("/Addresses", (DataContext db) =>
{
    return db.Addresses.Where(a => a.IsDeleted == false).ToList();
});

#endregion

#region AddressTypes

app.MapGet("/AddressTypes", (DataContext db) =>
{
    return db.AddressTypes.Where(a => a.IsDeleted == false).ToList();
});

#endregion

#region Cities

app.MapGet("/Cities", (DataContext db) =>
{
    return db.Cities.Where(c => c.IsDeleted == false).ToList();
});

#endregion

#region Countries

app.MapGet("/Countries", (DataContext db) =>
{
    return db.Countries.Where(c => c.IsDeleted == false).ToList();
});

#endregion

#region People

app.MapGet("/People", (DataContext db) =>
{
    return db.People.Where(p => p.IsDeleted == false).ToList();
});

#endregion

#region States

app.MapGet("/States", (DataContext db) =>
{
    return db.States.Where(s => s.IsDeleted == false).ToList();
});

#endregion

#region TelephoneNumbers

app.MapGet("/TelephoneNumbers", (DataContext db) =>
{
    return db.TelephoneNumbers.Where(t => t.IsDeleted == false).ToList();
});

#endregion

#region TelephoneNumberTypes

app.MapGet("/TelephoneNumberTypes", (DataContext db) =>
{
    return db.TelephoneNumberTypes.Where(t => t.IsDeleted == false).ToList();
});

#endregion

#endregion


var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateTime.Now.AddDays(index),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}