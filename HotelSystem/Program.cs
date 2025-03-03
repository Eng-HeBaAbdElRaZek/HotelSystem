using AutoMapper;
using ExaminantionSystem_R3.DTOs.Questions;
using HotelSystem.Helpers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(RoomProfile).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}
AutoMapperHelper.Mapper = app.Services.GetService<IMapper>();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
