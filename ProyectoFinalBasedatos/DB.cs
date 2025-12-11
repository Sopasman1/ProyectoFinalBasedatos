using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace ProyectoFinalBasedatos
{
    internal class DB
    {
        private static string connectionString =
        "Host=localhost;Port=5432;Username=postgres;Password=1234;Database=FinalProyect;";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}
