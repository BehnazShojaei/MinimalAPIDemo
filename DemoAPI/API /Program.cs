using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var itemsGroup = app.MapGroup("/api");

app.MapGet("/", () => "Hello World!");
itemsGroup.MapGet("/hi", () => "Hi!");
itemsGroup.MapPost("/items", (Item item) =>
{
    return Results.Ok();
});


// app.Run();
app.Run($"http://0.0.0.0:{Environment.GetEnvironmentVariable("PORT") ?? "5224"}");

public class Item
{
    public int Id { get; set; }
    public string? Name { get; set; }
}