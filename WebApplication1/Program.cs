using Microsoft.Data.SqlClient;
using SQLRepository;
using SQLRepository.Repository;
using System.Data;
using WebAppService.Interface;
using WebAppService.Service;
var builder = WebApplication.CreateBuilder(args);
// Add services to the container;
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IStudentservice, StudentService>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
var configuration =new ConfigurationBuilder()
    .AddJsonFile("appsettings.json",optional:false,reloadOnChange:true)
    .AddEnvironmentVariables() 
    .Build();

string connectionString = configuration.GetConnectionString("SqlConnection");

builder.Services.AddScoped<IDbConnection>(provider =>
{
    var connection = new SqlConnection(connectionString);
    return connection;
});

var app = builder.Build();
//register the service

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
