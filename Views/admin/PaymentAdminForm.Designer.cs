﻿namespace shop_management_system.Views.admin
{
    partial class PaymentAdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            flpInvoices = new FlowLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel6 = new Panel();
            lblWelcome = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            panel4 = new Panel();
            panel5 = new Panel();
            pbProfile = new components.PictureBoxComponent1();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            btnReports = new components.ButtonSidebar1();
            btnEmployees = new components.ButtonSidebar1();
            btnCustomers = new components.ButtonSidebar1();
            btnMyOrders = new components.ButtonSidebar1();
            btnPayments = new components.ButtonSidebar();
            btnCategories = new components.ButtonSidebar1();
            btnProdcuts = new components.ButtonSidebar1();
            pbLogo = new PictureBox();
            panel1 = new Panel();
            panel3 = new Panel();
            logoutButton1 = new components.LogoutButton();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfile).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1441, 773);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(flpInvoices, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(223, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(1215, 767);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // flpInvoices
            // 
            flpInvoices.AutoScroll = true;
            flpInvoices.Dock = DockStyle.Fill;
            flpInvoices.Location = new Point(30, 115);
            flpInvoices.Margin = new Padding(30);
            flpInvoices.Name = "flpInvoices";
            flpInvoices.Size = new Size(1207, 689);
            flpInvoices.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel4.Controls.Add(panel6, 0, 0);
            tableLayoutPanel4.Controls.Add(panel4, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(1261, 79);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(lblWelcome);
            panel6.Controls.Add(btnSearch);
            panel6.Controls.Add(txtSearch);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(1105, 76);
            panel6.TabIndex = 2;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14F);
            lblWelcome.ForeColor = Color.FromArgb(255, 101, 0);
            lblWelcome.Location = new Point(24, 19);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(78, 32);
            lblWelcome.TabIndex = 3;
            lblWelcome.Text = "label1";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(665, 17);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(103, 42);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 14F);
            txtSearch.Location = new Point(318, 19);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(321, 39);
            txtSearch.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(1114, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(144, 76);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(pbProfile);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(144, 76);
            panel5.TabIndex = 1;
            // 
            // pbProfile
            // 
            pbProfile.BackColor = Color.Transparent;
            pbProfile.Image = Properties.Resources.photo_2023_08_01_20_25_42;
            pbProfile.Location = new Point(40, 5);
            pbProfile.Name = "pbProfile";
            pbProfile.Size = new Size(65, 65);
            pbProfile.TabIndex = 0;
            pbProfile.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Controls.Add(panel1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.Size = new Size(214, 767);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnReports);
            panel2.Controls.Add(btnEmployees);
            panel2.Controls.Add(btnCustomers);
            panel2.Controls.Add(btnMyOrders);
            panel2.Controls.Add(btnPayments);
            panel2.Controls.Add(btnCategories);
            panel2.Controls.Add(btnProdcuts);
            panel2.Controls.Add(pbLogo);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(214, 617);
            panel2.TabIndex = 2;
            // 
            // btnReports
            // 
            btnReports.BackColor = SystemColors.Control;
            btnReports.BackgroundColor = SystemColors.Control;
            btnReports.BorderColor = Color.PaleVioletRed;
            btnReports.BorderRadius = 10;
            btnReports.BorderSize = 0;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI Semibold", 12F);
            btnReports.ForeColor = Color.Black;
            btnReports.Location = new Point(10, 472);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(15, 5, 30, 5);
            btnReports.Size = new Size(188, 50);
            btnReports.TabIndex = 10;
            btnReports.Text = "Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.TextColor = Color.Black;
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = SystemColors.Control;
            btnEmployees.BackgroundColor = SystemColors.Control;
            btnEmployees.BorderColor = Color.PaleVioletRed;
            btnEmployees.BorderRadius = 10;
            btnEmployees.BorderSize = 0;
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Segoe UI Semibold", 12F);
            btnEmployees.ForeColor = Color.Black;
            btnEmployees.Location = new Point(10, 416);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Padding = new Padding(15, 5, 30, 5);
            btnEmployees.Size = new Size(188, 50);
            btnEmployees.TabIndex = 9;
            btnEmployees.Text = "Employees";
            btnEmployees.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployees.TextColor = Color.Black;
            btnEmployees.UseVisualStyleBackColor = false;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = SystemColors.Control;
            btnCustomers.BackgroundColor = SystemColors.Control;
            btnCustomers.BorderColor = Color.PaleVioletRed;
            btnCustomers.BorderRadius = 10;
            btnCustomers.BorderSize = 0;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Segoe UI Semibold", 12F);
            btnCustomers.ForeColor = Color.Black;
            btnCustomers.Location = new Point(9, 360);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Padding = new Padding(15, 5, 30, 5);
            btnCustomers.Size = new Size(188, 50);
            btnCustomers.TabIndex = 8;
            btnCustomers.Text = "Customers";
            btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomers.TextColor = Color.Black;
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnMyOrders
            // 
            btnMyOrders.BackColor = SystemColors.Control;
            btnMyOrders.BackgroundColor = SystemColors.Control;
            btnMyOrders.BorderColor = Color.PaleVioletRed;
            btnMyOrders.BorderRadius = 10;
            btnMyOrders.BorderSize = 0;
            btnMyOrders.FlatAppearance.BorderSize = 0;
            btnMyOrders.FlatStyle = FlatStyle.Flat;
            btnMyOrders.Font = new Font("Segoe UI Semibold", 12F);
            btnMyOrders.ForeColor = Color.Black;
            btnMyOrders.Location = new Point(10, 248);
            btnMyOrders.Name = "btnMyOrders";
            btnMyOrders.Padding = new Padding(15, 5, 30, 5);
            btnMyOrders.Size = new Size(188, 50);
            btnMyOrders.TabIndex = 6;
            btnMyOrders.Text = "Carts";
            btnMyOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnMyOrders.TextColor = Color.Black;
            btnMyOrders.UseVisualStyleBackColor = false;
            btnMyOrders.Click += btnMyOrders_Click_1;
            // 
            // btnPayments
            // 
            btnPayments.BackColor = Color.FromArgb(255, 101, 0);
            btnPayments.BackgroundColor = Color.FromArgb(255, 101, 0);
            btnPayments.BorderColor = Color.PaleVioletRed;
            btnPayments.BorderRadius = 10;
            btnPayments.BorderSize = 0;
            btnPayments.FlatAppearance.BorderSize = 0;
            btnPayments.FlatStyle = FlatStyle.Flat;
            btnPayments.Font = new Font("Segoe UI Semibold", 12F);
            btnPayments.ForeColor = Color.White;
            btnPayments.Location = new Point(10, 304);
            btnPayments.Name = "btnPayments";
            btnPayments.Padding = new Padding(15, 5, 30, 5);
            btnPayments.Size = new Size(189, 50);
            btnPayments.TabIndex = 4;
            btnPayments.Text = "Payments";
            btnPayments.TextAlign = ContentAlignment.MiddleLeft;
            btnPayments.TextColor = Color.White;
            btnPayments.UseVisualStyleBackColor = false;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = SystemColors.Control;
            btnCategories.BackgroundColor = SystemColors.Control;
            btnCategories.BorderColor = Color.PaleVioletRed;
            btnCategories.BorderRadius = 10;
            btnCategories.BorderSize = 0;
            btnCategories.FlatAppearance.BorderSize = 0;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Segoe UI Semibold", 12F);
            btnCategories.ForeColor = Color.Black;
            btnCategories.Location = new Point(9, 192);
            btnCategories.Name = "btnCategories";
            btnCategories.Padding = new Padding(15, 5, 30, 5);
            btnCategories.Size = new Size(188, 50);
            btnCategories.TabIndex = 7;
            btnCategories.Text = "Cagetories";
            btnCategories.TextAlign = ContentAlignment.MiddleLeft;
            btnCategories.TextColor = Color.Black;
            btnCategories.UseVisualStyleBackColor = false;
            btnCategories.Click += btnCategory_Click;
            // 
            // btnProdcuts
            // 
            btnProdcuts.BackColor = SystemColors.Control;
            btnProdcuts.BackgroundColor = SystemColors.Control;
            btnProdcuts.BorderColor = Color.PaleVioletRed;
            btnProdcuts.BorderRadius = 10;
            btnProdcuts.BorderSize = 0;
            btnProdcuts.FlatAppearance.BorderSize = 0;
            btnProdcuts.FlatStyle = FlatStyle.Flat;
            btnProdcuts.Font = new Font("Segoe UI Semibold", 12F);
            btnProdcuts.ForeColor = Color.Black;
            btnProdcuts.Location = new Point(9, 136);
            btnProdcuts.Name = "btnProdcuts";
            btnProdcuts.Padding = new Padding(15, 5, 30, 5);
            btnProdcuts.Size = new Size(188, 50);
            btnProdcuts.TabIndex = 5;
            btnProdcuts.Text = "Products";
            btnProdcuts.TextAlign = ContentAlignment.MiddleLeft;
            btnProdcuts.TextColor = Color.Black;
            btnProdcuts.UseVisualStyleBackColor = false;
            btnProdcuts.Click += btnProducts_Click;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.bms;
            pbLogo.Location = new Point(19, 4);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(109, 109);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 620);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 144);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(logoutButton1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(208, 144);
            panel3.TabIndex = 3;
            // 
            // logoutButton1
            // 
            logoutButton1.BackColor = Color.FromArgb(250, 64, 50);
            logoutButton1.BackgroundColor = Color.FromArgb(250, 64, 50);
            logoutButton1.BorderColor = Color.PaleVioletRed;
            logoutButton1.BorderRadius = 10;
            logoutButton1.BorderSize = 0;
            logoutButton1.FlatAppearance.BorderSize = 0;
            logoutButton1.FlatStyle = FlatStyle.Flat;
            logoutButton1.Font = new Font("Segoe UI Semibold", 12F);
            logoutButton1.ForeColor = Color.White;
            logoutButton1.Location = new Point(39, 0);
            logoutButton1.Name = "logoutButton1";
            logoutButton1.Padding = new Padding(15, 8, 15, 8);
            logoutButton1.Size = new Size(129, 51);
            logoutButton1.TabIndex = 1;
            logoutButton1.Text = "Logout";
            logoutButton1.TextColor = Color.White;
            logoutButton1.UseVisualStyleBackColor = false;
            logoutButton1.Click += logoutButton1_Click;
            // 
            // PaymentAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1441, 773);
            Controls.Add(tableLayoutPanel1);
            Name = "PaymentAdminForm";
            Text = "PaymentAdminForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbProfile).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel6;
        private Label lblWelcome;
        private Button btnSearch;
        private TextBox txtSearch;
        private Panel panel4;
        private Panel panel5;
        private components.PictureBoxComponent1 pbProfile;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private components.ButtonSidebar1 btnReports;
        private components.ButtonSidebar1 btnEmployees;
        private components.ButtonSidebar1 btnCustomers;
        private components.ButtonSidebar1 btnMyOrders;
        private components.ButtonSidebar btnPayments;
        private components.ButtonSidebar1 btnCategories;
        private components.ButtonSidebar1 btnProdcuts;
        private PictureBox pbLogo;
        private Panel panel1;
        private Panel panel3;
        private components.LogoutButton logoutButton1;
        private FlowLayoutPanel flpInvoices;
    }
}