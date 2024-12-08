﻿using shop_management_system.Controllers;
using shop_management_system.Models;
using shop_management_system.Utils;
using shop_management_system.Views.admin;

namespace shop_management_system.Views
{
    public partial class LoginForm : Form
    {
        private EmployeeController employeeController;
        public LoginForm()
        {
            InitializeComponent();
            employeeController = new EmployeeController();
            // Make the form full screen
            this.WindowState = FormWindowState.Maximized; // Maximized state
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            Employee employee = employeeController.Login(username, password);
            if (employee != null)
            {
                MessageBox.Show("Login successful! Welcome, " + employee.Name);

                // Store the logged-in user in the session
                UserSession.CurrentUser = employee;

                // Navigate based on the user's role
                Form dashboardForm;
                if (employee.Role.Equals("admin", StringComparison.OrdinalIgnoreCase))
                {
                    dashboardForm = new DashboardAdminForm();
                }
                else
                {
                    dashboardForm = new DashboardForm();
                }

                dashboardForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            this.Hide();
        }
    }
}
