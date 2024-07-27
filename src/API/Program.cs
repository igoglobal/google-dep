using API;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/api/books", () =>
{
    List<Book> books = [
        new Book{Id = 1, Title = "Lord of the Rings"},
        new Book{Id = 2, Title = "Tempest"}
        
        ];

    return Results.Ok(books);
});

app.Run();
