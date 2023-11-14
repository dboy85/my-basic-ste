using System;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var timeTick = DateTime.Now.Ticks;
app.MapGet("/", () => $"Hello World! It is {timeTick}");

app.Run();
