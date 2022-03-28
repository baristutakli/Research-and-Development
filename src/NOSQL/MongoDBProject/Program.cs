using Microsoft.Extensions.Options;
using MongoDBProject.Common;
using MongoDBProject.Common.Concrete;
using MongoDBProject.Common.Context;
using MongoDBProject.Common.Interfaces;
using MongoDBProject.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.Configure<MongoDBSettings>(builder.Configuration.GetSection("MongoDB"));

builder.Services.AddSingleton<IMongoDBSettings>(serviceProvider =>
    serviceProvider.GetRequiredService<IOptions<MongoDBSettings>>().Value);

builder.Services.AddScoped<IPlaylistRepository, PlaylistRepository>();
builder.Services.AddScoped<IMongoContext, MongoContext>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
