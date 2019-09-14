using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Blog.Infra
{
    public class BlogContext : DbContext
    {

        // DbSet < NOME_DA_CLASS > NOME_DA_TABELA 

        public DbSet<Post> Post { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            IConfiguration configuration = builder.Build();

            string stringConexao = configuration.GetConnectionString("Blog");

            optionsBuilder.UseSqlServer(stringConexao);
        }


    }
}
