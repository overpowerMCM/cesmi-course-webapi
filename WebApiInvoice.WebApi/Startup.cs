using System.Text.Json.Serialization;
using Newtonsoft.Json;
using WebApiInvoice.Application.Interfaces;
using WebApiInvoice.Application.Services;
using WebApiInvoice.DataAccessLayer;

public static class Startup
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddDataAccessLayer();

        services.AddScoped<IProductService, ProductService>();

        services.AddControllers()
        .AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles)
        .AddNewtonsoftJson(options =>
        {
            options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
        });

        services.AddEndpointsApiExplorer();

        services.AddSwaggerGen();

    }


    public static void AddMiddlewares(this WebApplication app)
    {
        app.MapControllers();
        app.UseCors();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Web API");
                c.RoutePrefix = "docs";
            });
        }

        app.UseHttpsRedirection();
    }
}