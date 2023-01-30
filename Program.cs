
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PizzaStore.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//var sqlConBuilder = new SqlConnectionStringBuilder();
//sqlConBuilder.ConnectionString = builder.Configuration.GetConnectionString("SQLDbConnection");
//sqlConBuilder.UserID = builder.Configuration["UserID"];
//sqlConBuilder.Password = builder.Configuration["Password"];

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<WsApplicationDbContext>(options =>
options.UseSqlite(connectionString));

builder.Services.AddScoped<ICommandRepo, CommandRepo>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()); 
/*
https://www.youtube.com/watch?v=5YB49OEmbbE
1:30:00
*/
//builder.Services.AddDbContext<WsApplicationDbContext>(opt =>
  //  opt.UseSqlServer(sqlConBuilder.ConnectionString));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.MapGet("/helloworld", () => "Hello World!");

app.Run();
