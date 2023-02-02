using Model;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var categories = builder.Configuration.GetSection("Categories").Get<List<String>>();
categories.Sort();
var discounts = builder.Configuration.GetSection("Discounts").Get<List<Discount>>();

app.MapGet("/", () => "Hello World!");
app.MapGet("/api/categories", () => categories);
app.MapGet("/api/discounts", () => discounts);

app.Run();
