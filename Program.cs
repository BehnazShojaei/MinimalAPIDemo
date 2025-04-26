using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var itemsGroup = app.MapGroup("/api");

itemsGroup.MapGet("/", () => "Hello World!");
itemsGroup.MapGet("/hi", () => "Hi!");
itemsGroup.MapPost("/items", (Item item) =>
{
    return Results.Ok();
});


app.Run();

public class Item
{
    public int Id { get; set; }
    public string? MyProperty { get; set; }
}