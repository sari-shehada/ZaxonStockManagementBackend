using Zaxon.CustomsStockManagement.Application;
using Zaxon.CustomsStockManagement.Infrastructure;


var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
        .AddInfrastructure(builder.Configuration)
        .AddApplication();
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
}

var app = builder.Build();
{

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

}