using BookHouse.Infrastructure;
using Business;
using Business.Abstraction;
using DataAccess;
using DataAccess.Abstraction;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Add(new ServiceDescriptor(typeof(IHumanDao), typeof(HumanDao), ServiceLifetime.Singleton));
builder.Services.Add(new ServiceDescriptor(typeof(IBookDao), typeof(BookDao), ServiceLifetime.Singleton));
builder.Services.Add(new ServiceDescriptor(typeof(ILibraryCardDao), typeof(LibraryCardDao), ServiceLifetime.Singleton));
builder.Services.Add(new ServiceDescriptor(typeof(IHumanService), typeof(HumanService), ServiceLifetime.Singleton));
builder.Services.Add(new ServiceDescriptor(typeof(IBookService), typeof(BookService), ServiceLifetime.Singleton));
builder.Services.Add(new ServiceDescriptor(typeof(ILibraryCardService), typeof(LibraryCardService), ServiceLifetime.Singleton));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
/// <summary>
/// 2.2.3; 2.2.4
/// </summary>
app.UseMiddleware<ExceptionMiddleware>();
app.UseMiddleware<RejectUnauthorizedMiddleware>();

app.MapControllers();

app.Run();
