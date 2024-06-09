using PinarSutApi.Models;
using PinarSutApi.Repository.PinarS�tRepository;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<context>();

// Add services to the container.
builder.Services.AddTransient<IPinarS�tRepository,P�narS�tRepository>();


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
