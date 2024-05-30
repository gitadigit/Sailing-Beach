using Sailing.Core;
using Sailing.Core.Repository;
using Sailing.Core.Service;
using Sailing.Data;
using Sailing.Data.Repository;
using Sailing.Service;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Context>();
builder.Services.AddScoped<IBoatRepository,BoatRepository>();
builder.Services.AddScoped<IBoatService, BoatService>();
builder.Services.AddScoped<IBoatDriveRepository, BoatDriverRepository>();
builder.Services.AddScoped<IBoatDriverService, BoatDriverService>();
builder.Services.AddScoped<ISailingTimeRepository, TimeSailingRepository>();
builder.Services.AddScoped<ISalingTimeService, SalingTimeService>();

builder.Services.AddAutoMapper(typeof(MappingProfile));
//builder.Services.AddSingleton<Mapping>();

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
