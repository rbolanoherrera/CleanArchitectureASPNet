using InventarioApp.Repository.Dapper;
using InventarioApp.Repository.EFCore;
using InventarioApp.Presenters;
using InventarioApp.Builders;
using InventarioApp.Productos.UseCases;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDapperRepository();
builder.Services.AddEFCoreRepositories(builder.Configuration);
builder.Services.AddPresenters();
builder.Services.AddBuilders();
builder.Services.AddProductosUseCases();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
