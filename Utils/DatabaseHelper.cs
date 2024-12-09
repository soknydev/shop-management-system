﻿using MySql.Data.MySqlClient;

namespace shop_management_system.Utils
{
    public static class DatabaseHelper
    {
        private static string server = "localhost";         // Server IP or domain
        private static string database = "sms";    // Database name
        private static string userId = "sokny";             // Username
        private static string password = "1234Dev&&";       // Password
        private static int port = 3306;                     // MySQL port

        /*private static string server = "34.126.93.142";
        private static string database = "testdb";
        private static string userId = "koko";
        private static string password = "koko123";
        private static int port = 5049;*/

        // Construct the connection string
        private static readonly string connectionString =
            $"Server={server};Port={port};Database={database};User Id={userId};Password={password};";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }




}
