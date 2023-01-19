using Final_Project.Data;
using Final_Project.Models;
using Final_Project.Repositories;
using Final_Project.Repositories.IRepositories;
using Final_Project.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text.Json.Serialization;

namespace Final_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<RepairShopContext>(option =>
            {
                option.UseSqlite(builder.Configuration.GetConnectionString("RepairShopConnectionString"));
            });
            builder.Services.AddTransient<ITicketRepository, TicketRepository>();
            builder.Services.AddTransient<ITicketAdapter, TicketAdapter>();
            
            builder.Services.AddControllers()
                .AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(option =>
            {
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                option.IncludeXmlComments(xmlPath, includeControllerXmlComments: true);
            });

            builder.Services.AddCors(p => p.AddPolicy("CorsForRepairShop", builder =>
            {
                builder.WithOrigins("*")
                .AllowAnyMethod()
                .AllowAnyHeader();
            }));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors("CorsForRepairShop");
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}