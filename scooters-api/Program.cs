using Microsoft.EntityFrameworkCore;
using FluentMigrator.Runner;
using scooters_api.Data.Migrations;
using scooter_api.Scooters.Repository;
using System.ComponentModel.Design;
using scooter_api.Scooters.Service;

public class Program
{

    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddCors(options =>

         options.AddPolicy("scooters-api", domain =>
         domain.WithOrigins("")
         .AllowAnyHeader()
         .AllowAnyMethod()));


        builder.Services.AddDbContext<AppDbContext>(options =>

        options.UseMySql(builder.Configuration.GetConnectionString("Default")!,
        new MySqlServerVersion(new Version(8, 0, 21))));

        builder.Services.AddScoped<IScooterRepository, ScooterRepository>();
        builder.Services.AddScoped<IScooterCommandService, ScooterCommandService>();
        builder.Services.AddScoped<IScooterQueryService, ScooterQueryService>();

        builder.Services.AddFluentMigratorCore()
            .ConfigureRunner(rb => rb.AddMySql5()
            .WithGlobalConnectionString(builder.Configuration.GetConnectionString("Default"))
            .ScanIn(typeof(Program).Assembly).For.Migrations())
            .AddLogging(lb => lb.AddFluentMigratorConsole());

        builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        var app = builder.Build();


        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseHttpsRedirection();
            app.MapControllers();

        }

        using (var scope = app.Services.CreateScope())
        {

            try
            {
                var runner = scope.ServiceProvider.GetRequiredService<IMigrationRunner>();

                runner = scope.ServiceProvider.GetRequiredService<IMigrationRunner>();
                runner.MigrateUp();
                Console.WriteLine("Migrare cu succes");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Erroare migrare");

            }

        }

        app.UseCors("scooters-api");
        app.Run();
    }
}
