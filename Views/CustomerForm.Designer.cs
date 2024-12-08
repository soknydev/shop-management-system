﻿namespace shop_management_system.Views
{
    partial class CustomerForm
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
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            panel3 = new Panel();
            logoutButton1 = new components.LogoutButton();
            panel2 = new Panel();
            btnProducts = new components.ButtonSidebar1();
            btnMyOrders = new components.ButtonSidebar1();
            btnCustomers = new components.ButtonSidebar();
            btnMyPayments = new components.ButtonSidebar1();
            btnCategories = new components.ButtonSidebar1();
            pbLogo = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel4 = new Panel();
            panel5 = new Panel();
            pbProfile = new components.PictureBoxComponent1();
            panel6 = new Panel();
            panel7 = new Panel();
            lblWelcome = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            panel8 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel9 = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            flowLayoutPanelCustomers = new FlowLayoutPanel();
            cartCustomerControl1 = new components.userControl.CartCustomerControl();
            panel10 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel11 = new Panel();
            btnAddCustomer = new components.ButtonComponent1();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfile).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel9.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            flowLayoutPanelCustomers.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1890, 754);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 1);
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.Size = new Size(214, 748);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(3, 601);
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
            panel3.TabIndex = 2;
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
            // 
            // panel2
            // 
            panel2.Controls.Add(btnProducts);
            panel2.Controls.Add(btnMyOrders);
            panel2.Controls.Add(btnCustomers);
            panel2.Controls.Add(btnMyPayments);
            panel2.Controls.Add(btnCategories);
            panel2.Controls.Add(pbLogo);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(208, 592);
            panel2.TabIndex = 1;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = SystemColors.Control;
            btnProducts.BackgroundColor = SystemColors.Control;
            btnProducts.BorderColor = Color.PaleVioletRed;
            btnProducts.BorderRadius = 10;
            btnProducts.BorderSize = 0;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI Semibold", 12F);
            btnProducts.ForeColor = Color.Black;
            btnProducts.Location = new Point(10, 132);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new Padding(15, 5, 30, 5);
            btnProducts.Size = new Size(188, 50);
            btnProducts.TabIndex = 13;
            btnProducts.Text = "Payments";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.TextColor = Color.Black;
            btnProducts.UseVisualStyleBackColor = false;
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
            btnMyOrders.Location = new Point(9, 244);
            btnMyOrders.Name = "btnMyOrders";
            btnMyOrders.Padding = new Padding(15, 5, 30, 5);
            btnMyOrders.Size = new Size(188, 50);
            btnMyOrders.TabIndex = 11;
            btnMyOrders.Text = "Carts";
            btnMyOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnMyOrders.TextColor = Color.Black;
            btnMyOrders.UseVisualStyleBackColor = false;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.FromArgb(255, 101, 0);
            btnCustomers.BackgroundColor = Color.FromArgb(255, 101, 0);
            btnCustomers.BorderColor = Color.PaleVioletRed;
            btnCustomers.BorderRadius = 10;
            btnCustomers.BorderSize = 0;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Segoe UI Semibold", 12F);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Location = new Point(10, 356);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Padding = new Padding(15, 5, 30, 5);
            btnCustomers.Size = new Size(189, 50);
            btnCustomers.TabIndex = 9;
            btnCustomers.Text = "Customers";
            btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomers.TextColor = Color.White;
            btnCustomers.UseVisualStyleBackColor = false;
            // 
            // btnMyPayments
            // 
            btnMyPayments.BackColor = SystemColors.Control;
            btnMyPayments.BackgroundColor = SystemColors.Control;
            btnMyPayments.BorderColor = Color.PaleVioletRed;
            btnMyPayments.BorderRadius = 10;
            btnMyPayments.BorderSize = 0;
            btnMyPayments.FlatAppearance.BorderSize = 0;
            btnMyPayments.FlatStyle = FlatStyle.Flat;
            btnMyPayments.Font = new Font("Segoe UI Semibold", 12F);
            btnMyPayments.ForeColor = Color.Black;
            btnMyPayments.Location = new Point(10, 300);
            btnMyPayments.Name = "btnMyPayments";
            btnMyPayments.Padding = new Padding(15, 5, 30, 5);
            btnMyPayments.Size = new Size(188, 50);
            btnMyPayments.TabIndex = 12;
            btnMyPayments.Text = "Payments";
            btnMyPayments.TextAlign = ContentAlignment.MiddleLeft;
            btnMyPayments.TextColor = Color.Black;
            btnMyPayments.UseVisualStyleBackColor = false;
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
            btnCategories.Location = new Point(10, 188);
            btnCategories.Name = "btnCategories";
            btnCategories.Padding = new Padding(15, 5, 30, 5);
            btnCategories.Size = new Size(188, 50);
            btnCategories.TabIndex = 10;
            btnCategories.Text = "Categories";
            btnCategories.TextAlign = ContentAlignment.MiddleLeft;
            btnCategories.TextColor = Color.Black;
            btnCategories.UseVisualStyleBackColor = false;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.bms;
            pbLogo.Location = new Point(19, 0);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(109, 109);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 8;
            pbLogo.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(panel8, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(223, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1664, 748);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel4.Controls.Add(panel4, 1, 0);
            tableLayoutPanel4.Controls.Add(panel6, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(1658, 79);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(1511, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(144, 73);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(pbProfile);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(144, 73);
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
            // panel6
            // 
            panel6.Controls.Add(panel7);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(1502, 73);
            panel6.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(lblWelcome);
            panel7.Controls.Add(btnSearch);
            panel7.Controls.Add(txtSearch);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(1502, 73);
            panel7.TabIndex = 2;
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
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(tableLayoutPanel5);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(3, 88);
            panel8.Name = "panel8";
            panel8.Size = new Size(1658, 657);
            panel8.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel5.Controls.Add(panel9, 0, 0);
            tableLayoutPanel5.Controls.Add(panel11, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(1658, 657);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(224, 224, 224);
            panel9.Controls.Add(tableLayoutPanel6);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(20, 20);
            panel9.Margin = new Padding(20);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(2);
            panel9.Size = new Size(1398, 617);
            panel9.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.BackColor = Color.White;
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Controls.Add(flowLayoutPanelCustomers, 0, 1);
            tableLayoutPanel6.Controls.Add(panel10, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(2, 2);
            tableLayoutPanel6.Margin = new Padding(4);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(1394, 613);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // flowLayoutPanelCustomers
            // 
            flowLayoutPanelCustomers.Controls.Add(cartCustomerControl1);
            flowLayoutPanelCustomers.Dock = DockStyle.Fill;
            flowLayoutPanelCustomers.Location = new Point(0, 65);
            flowLayoutPanelCustomers.Margin = new Padding(0);
            flowLayoutPanelCustomers.Name = "flowLayoutPanelCustomers";
            flowLayoutPanelCustomers.Size = new Size(1394, 548);
            flowLayoutPanelCustomers.TabIndex = 1;
            // 
            // cartCustomerControl1
            // 
            cartCustomerControl1.BackColor = SystemColors.Control;
            cartCustomerControl1.Location = new Point(0, 0);
            cartCustomerControl1.Margin = new Padding(0);
            cartCustomerControl1.Name = "cartCustomerControl1";
            cartCustomerControl1.Size = new Size(1784, 71);
            cartCustomerControl1.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Gainsboro;
            panel10.Controls.Add(label5);
            panel10.Controls.Add(label4);
            panel10.Controls.Add(label3);
            panel10.Controls.Add(label2);
            panel10.Controls.Add(label1);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(0, 0);
            panel10.Margin = new Padding(0);
            panel10.Name = "panel10";
            panel10.Size = new Size(1394, 65);
            panel10.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1217, 20);
            label5.Name = "label5";
            label5.Size = new Size(78, 28);
            label5.TabIndex = 4;
            label5.Text = "Update";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(837, 20);
            label4.Name = "label4";
            label4.Size = new Size(85, 28);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(540, 20);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(299, 22);
            label2.Name = "label2";
            label2.Size = new Size(152, 28);
            label2.TabIndex = 1;
            label2.Text = "Phone Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 20);
            label1.Name = "label1";
            label1.Size = new Size(160, 28);
            label1.TabIndex = 0;
            label1.Text = "Customer Name";
            // 
            // panel11
            // 
            panel11.Controls.Add(btnAddCustomer);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(1441, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(214, 651);
            panel11.TabIndex = 1;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = Color.FromArgb(255, 101, 0);
            btnAddCustomer.BackgroundColor = Color.FromArgb(255, 101, 0);
            btnAddCustomer.BorderColor = Color.PaleVioletRed;
            btnAddCustomer.BorderRadius = 10;
            btnAddCustomer.BorderSize = 0;
            btnAddCustomer.FlatAppearance.BorderSize = 0;
            btnAddCustomer.FlatStyle = FlatStyle.Flat;
            btnAddCustomer.Font = new Font("Segoe UI Semibold", 12F);
            btnAddCustomer.ForeColor = Color.White;
            btnAddCustomer.Location = new Point(14, 19);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Padding = new Padding(15, 8, 15, 8);
            btnAddCustomer.Size = new Size(185, 50);
            btnAddCustomer.TabIndex = 0;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.TextColor = Color.White;
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1890, 754);
            Controls.Add(tableLayoutPanel1);
            Name = "CustomerForm";
            Text = "CustomerForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbProfile).EndInit();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panel9.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            flowLayoutPanelCustomers.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Panel panel3;
        private components.LogoutButton logoutButton1;
        private Panel panel2;
        private components.ButtonSidebar1 btnProducts;
        private components.ButtonSidebar1 btnMyOrders;
        private components.ButtonSidebar btnCustomers;
        private components.ButtonSidebar1 btnMyPayments;
        private components.ButtonSidebar1 btnCategories;
        private PictureBox pbLogo;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel4;
        private Panel panel5;
        private components.PictureBoxComponent1 pbProfile;
        private Panel panel6;
        private Panel panel7;
        private Label lblWelcome;
        private Button btnSearch;
        private TextBox txtSearch;
        private Panel panel8;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel9;
        private TableLayoutPanel tableLayoutPanel6;
        private FlowLayoutPanel flowLayoutPanelCustomers;
        private components.userControl.CartCustomerControl cartCustomerControl1;
        private Panel panel10;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel11;
        private components.ButtonComponent1 btnAddCustomer;
    }
}