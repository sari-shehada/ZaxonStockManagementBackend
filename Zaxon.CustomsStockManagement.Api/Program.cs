using Microsoft.EntityFrameworkCore;
using Zaxon.CustomsStockManagement.Api.Common.BuildConfigurations;
using Zaxon.CustomsStockManagement.Application;
using Zaxon.CustomsStockManagement.Application.Common.DataSeeding;
using Zaxon.CustomsStockManagement.Infrastructure;
using Zaxon.CustomsStockManagement.Infrastructure.Data;


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
        if(app.Environment.IsDevelopmentHosting())
        {
            var context = scope.ServiceProvider.GetRequiredService<StockManagementDbContext>();
            await context.Database.MigrateAsync();
        }

        var seedingService = scope.ServiceProvider.GetRequiredService<IDataSeedingService>();
        await seedingService.SeedApplicationData();
    }
    if (app.Environment.IsDevelopment() || app.Environment.IsDevelopmentHosting())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();

}