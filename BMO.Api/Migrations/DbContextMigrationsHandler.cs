using BMO.Api.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data.Common;

namespace BMO.Api.Migrations
{
    public class DbContextMigrationsHandler
    {
        public static string connectionString = string.Empty;

        /// <summary>
        /// Reading environment variables and setting up a database connection..
        /// It will prioritize appSetting connection string with the name of "BMO-Database" over the environment variables if one exists..
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static string GetDatabaseConnectionString(WebApplicationBuilder builder)
        {
            if(!string.IsNullOrWhiteSpace(connectionString))
            {
                return connectionString;
            }

            var server = builder.Configuration["BMO_Database_Server"] ?? "";
            var port = builder.Configuration["BMO_Database_Port"] ?? "";
            var database = builder.Configuration["BMO_Database_Name"] ?? "";
            var username = builder.Configuration["BMO_Database_Username"] ?? "";
            var password = builder.Configuration["BMO_Database_Password"] ?? "";

            var envConnectionString = $"Server={server}, {port}; Initial Catalog={database}; User Id={username}; Password={password}";

            var appConnectionString = builder.Configuration.GetConnectionString("BMO-Database");

            connectionString = appConnectionString == null ? envConnectionString : appConnectionString;

            Console.WriteLine("Database Connection String:");
            Console.WriteLine(connectionString);

            return connectionString;
        }
        public async static Task<bool> PrepareDatabase(IApplicationBuilder appBuilder, WebApplicationBuilder webApplicationBuilder)
        {
            //var status = await CheckDatabaseStatus(webApplicationBuilder);

            //if (status) Console.WriteLine("Database connection online!");
            //else
            //{
            //    Console.WriteLine("Database connection offline!");
            //    return false;
            //}

            var serviceScope = appBuilder.ApplicationServices.CreateScope();
            
            await SeedData(serviceScope.ServiceProvider.GetService<BmodbContext>());

            return true;
            
        }

        public static async Task SeedData(BmodbContext context)
        {
            if (context is null)
                return;

            try
            {
                Console.WriteLine("Applying newest migrations or creating a database if one does not exist already, this can take a couple of minutes please be patient..");

                await context.Database.MigrateAsync();

                Console.WriteLine("Migrating..");

                await context.SaveChangesAsync();

                Console.WriteLine("Database successfully migrated!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error migrating the database.");
                Console.WriteLine(ex.ToString());
            }
        }

        public static async Task<bool> CheckDatabaseStatus(WebApplicationBuilder builder)
        {
            using (var connection = new SqlConnection(GetDatabaseConnectionString(builder)))
            {
                try
                {
                    await connection.OpenAsync();

                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }
    }
}
