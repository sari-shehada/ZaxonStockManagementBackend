using Zaxon.CustomsStockManagement.Application;
using Zaxon.CustomsStockManagement.Application.Common.DataSeeding;
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
    using (var scope  = app.Services.CreateScope())
    {
        var seedingService = scope.ServiceProvider.GetRequiredService<IDataSeedingService>();

        await seedingService.SeedApplicationData();
    }
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