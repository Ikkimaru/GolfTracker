using GolfTracker.Application.Services;
using GolfTracker.Core.Interfaces;
using GolfTracker.Data;
using GolfTracker.Infrastructure.Persistence;
using GolfTracker.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add your DbContext and other services
builder.Services.AddDbContext<GolfTrackerDbContext>(options =>
    options.UseSqlite("Data Source=./Database/GolfTracker.db"));


builder.Services.AddScoped<IGolfScoreRepository, GolfScoreRepository>();
builder.Services.AddScoped<IGolfCourseRepository, GolfCourseRepository>();
builder.Services.AddScoped<GolfScoreService>();
builder.Services.AddScoped<GolfCourseService>();

// Add services to the container.

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

// Seed the database
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<GolfTrackerDbContext>();
    await SeedData.Initialize(dbContext);
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
