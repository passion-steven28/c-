using Microsoft.EntityFrameworkCore;
using ticketer.core.context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Add database
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    var ConnectionString = "";
    options.UseSqlServer(connectionString: ConnectionString);
});

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
