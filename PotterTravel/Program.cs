using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PotterTravel.Data;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddCors(Options =>
{
    Options.AddPolicy(name: MyAllowSpecificOrigins,
        policy =>
    {
        policy.WithOrigins("*")
                .AllowAnyHeader()
                .AllowAnyMethod();
    });
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(Options => Options.UseMySql
(builder.Configuration.GetConnectionString("DefaultConnection"), ServerVersion.AutoDetect
(builder.Configuration.GetConnectionString("DefaultConnection"))));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.UseCors(MyAllowSpecificOrigins);

app.Run();
