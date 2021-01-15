using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SweetAndSavory.Models
{
  public class SweetAndSavoryContextSweetAndSavory : IDesignTimeDbContextSweetAndSavory<SweetAndSavoryContext>
  {

    SweetAndSavoryContext IDesignTimeDbContextSweetAndSavory<SweetAndSavoryContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<SweetAndSavoryContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new SweetAndSavoryContext(builder.Options);
    }
  }
}