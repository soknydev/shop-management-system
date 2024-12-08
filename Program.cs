using MySql.Data.MySqlClient;
using shop_management_system.Services;
using shop_management_system.Utils;
using shop_management_system.Views;

namespace shop_management_system
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // test database connection
            //TestDatabaseConnection();

            ProductService productService = new ProductService();
            //productService.PrintAllProducts();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());

            //Application.Run(new MainForm());



        }

        private static void TestDatabaseConnection()
        {
            try
            {
                using MySqlConnection connection = DatabaseHelper.GetConnection();
                connection.Open();
                MessageBox.Show("Connection successful!", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection failed: {ex.Message}", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}