using Zaxon.CustomsStockManagement.Infrastructure.Config;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.ConfigureInfrastructure(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

//TODO: Create an extension method for DevHosting Env
if (app.Environment.IsDevelopment() || app.Environment.EnvironmentName == "DevelopmentHosting")
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
