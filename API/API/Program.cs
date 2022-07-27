using DAL.DataAccess;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


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

#region Endpoints

#region Addresses

app.MapPost("/Addresses", async (Address obj, DataContext db) =>
{
    db.Addresses.Add(obj);
    await db.SaveChangesAsync();
    return Results.Created($"/Addresses/{obj.Id}", obj);
});

app.MapGet("/Addresses", (DataContext db) =>
{
    var entity = db.Addresses.Where(a => a.IsDeleted == false).ToList();
    return entity is not null ? Results.Ok(entity) : Results.NotFound();
});

app.MapGet("/Addresses{id}", (int id, DataContext db) =>
{
    var entity = db.Addresses.Where(a => a.Id == id).ToList();
    return entity.Count() > 0 ? Results.Ok(entity) : Results.NotFound();
});

app.MapPut("/Addresses", (Address obj, DataContext db) =>
{
    try
    {
        db.Addresses.Update(obj);
        db.SaveChanges();
    }
    catch
    {
        return false;
    }
    return true;
});

#endregion

#region AddressTypes

app.MapPost("/AddressTypes", async (AddressType obj, DataContext db) =>
{
    db.AddressTypes.Add(obj);
    await db.SaveChangesAsync();
    return Results.Created($"/AddressTypes/{obj.Id}", obj);
});

app.MapGet("/AddressTypes", (DataContext db) =>
{
    var entity = db.AddressTypes.Where(a => a.IsDeleted == false).ToList();
    return entity is not null ? Results.Ok(entity) : Results.NotFound();
});

app.MapGet("/AddressTypes{id}", (int id, DataContext db) =>
{
    var entity = db.AddressTypes.Where(a => a.Id == id).ToList();
    return entity.Count() > 0 ? Results.Ok(entity) : Results.NotFound();
});

app.MapPut("/AddressTypes", (AddressType obj, DataContext db) =>
{
    try
    {
        db.AddressTypes.Update(obj);
        db.SaveChanges();
    }
    catch
    {
        return false;
    }
    return true;
});

#endregion

#region Cities

app.MapPost("/Cities", async (City obj, DataContext db) =>
{
    db.Cities.Add(obj);
    await db.SaveChangesAsync();
    return Results.Created($"/Cities/{obj.Id}", obj);
});

app.MapGet("/Cities", (DataContext db) =>
{
    var entity = db.Cities.Where(a => a.IsDeleted == false).ToList();
    return entity is not null ? Results.Ok(entity) : Results.NotFound();
});

app.MapGet("/Cities{id}", (int id, DataContext db) =>
{
    var entity = db.Cities.Where(a => a.Id == id).ToList();
    return entity.Count() > 0 ? Results.Ok(entity) : Results.NotFound();
});

app.MapPut("/Cities", (City obj, DataContext db) =>
{
    try
    {
        db.Cities.Update(obj);
        db.SaveChanges();
    }
    catch
    {
        return false;
    }
    return true;
});

#endregion

#region Countries

app.MapPost("/Countries", async (Country obj, DataContext db) =>
{
    db.Countries.Add(obj);
    await db.SaveChangesAsync();
    return Results.Created($"/Countries/{obj.Id}", obj);
});

app.MapGet("/Countries", (DataContext db) =>
{
    var entity = db.Countries.Where(a => a.IsDeleted == false).ToList();
    return entity is not null ? Results.Ok(entity) : Results.NotFound();
});

app.MapGet("/Countries{id}", (int id, DataContext db) =>
{
    var entity = db.Countries.Where(a => a.Id == id).ToList();
    return entity.Count() > 0 ? Results.Ok(entity) : Results.NotFound();
});

app.MapPut("/Countries", (Country obj, DataContext db) =>
{
    try
    {
        db.Countries.Update(obj);
        db.SaveChanges();
    }
    catch
    {
        return false;
    }
    return true;
});

#endregion

#region People

app.MapPost("/People", async (Person obj, DataContext db) =>
{
    db.People.Add(obj);
    await db.SaveChangesAsync();
    return Results.Created($"/People/{obj.Id}", obj);
});

app.MapGet("/People", (DataContext db) =>
{
    var entity = db.People.Where(a => a.IsDeleted == false).ToList();
    return entity is not null ? Results.Ok(entity) : Results.NotFound();
});

app.MapGet("/People{id}", (int id, DataContext db) =>
{
    var entity = db.People.Where(a => a.Id == id).ToList();
    return entity.Count() > 0 ? Results.Ok(entity) : Results.NotFound();
});

app.MapPut("/People", (Person obj, DataContext db) =>
{
    try
    {
        db.People.Update(obj);
        db.SaveChanges();
    }
    catch
    {
        return false;
    }
    return true;
});

#endregion

#region States

app.MapPost("/States", async (State obj, DataContext db) =>
{
    db.States.Add(obj);
    await db.SaveChangesAsync();
    return Results.Created($"/States/{obj.Id}", obj);
});

app.MapGet("/States", (DataContext db) =>
{
    var entity = db.States.Where(a => a.IsDeleted == false).ToList();
    return entity is not null ? Results.Ok(entity) : Results.NotFound();
});

app.MapGet("/States{id}", (int id, DataContext db) =>
{
    var entity = db.States.Where(a => a.Id == id).ToList();
    return entity.Count() > 0 ? Results.Ok(entity) : Results.NotFound();
});

app.MapPut("/States", (State obj, DataContext db) =>
{
    try
    {
        db.States.Update(obj);
        db.SaveChanges();
    }
    catch
    {
        return false;
    }
    return true;
});

#endregion

#region TelephoneNumbers

app.MapPost("/TelephoneNumbers", async (TelephoneNumber obj, DataContext db) =>
{
    db.TelephoneNumbers.Add(obj);
    await db.SaveChangesAsync();
    return Results.Created($"/TelephoneNumbers/{obj.Id}", obj);
});

app.MapGet("/TelephoneNumbers", (DataContext db) =>
{
    var entity = db.TelephoneNumbers.Where(a => a.IsDeleted == false).ToList();
    return entity is not null ? Results.Ok(entity) : Results.NotFound();
});

app.MapGet("/TelephoneNumbers{id}", (int id, DataContext db) =>
{
    var entity = db.TelephoneNumbers.Where(a => a.Id == id).ToList();
    return entity.Count() > 0 ? Results.Ok(entity) : Results.NotFound();
});

app.MapPut("/TelephoneNumbers", (TelephoneNumber obj, DataContext db) =>
{
    try
    {
        db.TelephoneNumbers.Update(obj);
        db.SaveChanges();
    }
    catch
    {
        return false;
    }
    return true;
});

#endregion

#region TelephoneNumberTypes

app.MapPost("/TelephoneNumberTypes", async (TelephoneNumberType obj, DataContext db) =>
{
    db.TelephoneNumberTypes.Add(obj);
    await db.SaveChangesAsync();
    return Results.Created($"/TelephoneNumberTypes/{obj.Id}", obj);
});

app.MapGet("/TelephoneNumberTypes", (DataContext db) =>
{
    var entity = db.TelephoneNumberTypes.Where(a => a.IsDeleted == false).ToList();
    return entity is not null ? Results.Ok(entity) : Results.NotFound();
});

app.MapGet("/TelephoneNumberTypes{id}", (int id, DataContext db) =>
{
    var entity = db.TelephoneNumbers.Where(a => a.Id == id).ToList();
    return entity.Count() > 0 ? Results.Ok(entity) : Results.NotFound();
});

app.MapPut("/TelephoneNumberTypes", (TelephoneNumberType obj, DataContext db) =>
{
    try
    {
        db.TelephoneNumberTypes.Update(obj);
        db.SaveChanges();
    }
    catch
    {
        return false;
    }
    return true;
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