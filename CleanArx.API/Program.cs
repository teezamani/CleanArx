using CleanArx.Application;
using CleanArx.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

//Dependency Injection for the services
builder.Services.AddInfrastructureDI();
builder.Services.AddApplicationDI(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Enable endpoint routing for controllers
app.MapControllers();
app.Run();

