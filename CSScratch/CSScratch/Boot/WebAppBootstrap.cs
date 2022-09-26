using CSScratch.Json;
using CSScratch.Model.Media;

namespace CSScratch.Boot
{
    public static class WebAppBootstrap
    {

        public static WebApplication CreateApp(string[] args)
        {
            return CreateWebAppBuilder(args).Build().Configure();
        }

        public static WebApplicationBuilder CreateWebAppBuilder(string[] args)
        {
            return WebApplication.CreateBuilder(args).Configure();
        }

        public static WebApplicationBuilder Configure(this WebApplicationBuilder builder)
        {
            // Add services to the container.
            builder.Services.AddControllers().AddNewtonsoftJson(options => {
                options.SerializerSettings.AddPolymorphicJsonConverters();
            });

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            return builder;
        }

        public static WebApplication Configure(this WebApplication app)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            return app;
        }

    }
}
