﻿using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace Blog.Infra
{
    public class ConnectionFactory
    {

        public static SqlConnection CriaConexao()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            IConfiguration configuration = builder.Build();

            string stringConexao = configuration.GetConnectionString("Blog");

            SqlConnection conexao = new SqlConnection(stringConexao);

            conexao.Open();

            return conexao;
        }
    }
}
